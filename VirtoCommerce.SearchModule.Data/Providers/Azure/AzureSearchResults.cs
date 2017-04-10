﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Search.Models;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.SearchModule.Core.Model.Filters;
using VirtoCommerce.SearchModule.Core.Model.Indexing;
using VirtoCommerce.SearchModule.Core.Model.Search;
using VirtoCommerce.SearchModule.Core.Model.Search.Criterias;
using VirtoCommerce.SearchModule.Data.Services;

namespace VirtoCommerce.SearchModule.Data.Providers.Azure
{
    [CLSCompliant(false)]
    public class AzureSearchResults : ISearchResults<DocumentDictionary>
    {
        public AzureSearchResults(ISearchCriteria criteria, DocumentSearchResult<DocumentDictionary> searchResult)
        {
            SearchCriteria = criteria;
            Documents = ConvertDocuments(searchResult);
            DocCount = searchResult.Results.Count;
            TotalCount = searchResult.Count ?? 0;
            ProviderAggregations = searchResult.Facets;
            Facets = ConvertFacets(searchResult.Facets, criteria);
        }

        public IEnumerable<DocumentDictionary> Documents { get; }
        public ISearchCriteria SearchCriteria { get; }
        public long DocCount { get; }
        public FacetGroup[] Facets { get; }
        public string[] Suggestions { get; }
        public long TotalCount { get; }

        public FacetResults ProviderAggregations { get; set; }


        private static IList<DocumentDictionary> ConvertDocuments(DocumentSearchResult<DocumentDictionary> searchResult)
        {
            return searchResult.Results.Select(r => RenameFields(r.Document)).ToList();
        }

        private static FacetGroup[] ConvertFacets(FacetResults facets, ISearchCriteria criteria)
        {
            var result = new List<FacetGroup>();

            if (facets != null)
            {
                foreach (var filter in criteria.Filters)
                {
                    var attributeFilter = filter as AttributeFilter;
                    var rangeFilter = filter as RangeFilter;
                    var priceRangeFilter = filter as PriceRangeFilter;

                    var azureFieldName = priceRangeFilter != null
                        ? AzureQueryHelper.ToAzureFieldName($"{filter.Key}_{criteria.Currency}_{criteria.Pricelists?.FirstOrDefault()}").ToLowerInvariant()
                        : AzureQueryHelper.ToAzureFieldName(filter.Key).ToLowerInvariant();

                    if (facets.ContainsKey(azureFieldName))
                    {
                        var facetResults = facets[azureFieldName];
                        if (facetResults != null && facetResults.Count > 0)
                        {
                            var groupLabels = filter.GetLabels();
                            var values = filter.GetValues();
                            var facetGroup = new FacetGroup(filter.Key, groupLabels);

                            // Return all facet terms for attribute filter if values are not defined
                            if (values == null && attributeFilter != null)
                            {
                                facetGroup.FacetType = FacetTypes.Attribute;

                                foreach (var facetResult in facetResults)
                                {
                                    var newFacet = new Facet(facetGroup, facetResult.Value.ToString(), (int)facetResult.Count, null);
                                    facetGroup.Facets.Add(newFacet);
                                }
                            }

                            if (values != null)
                            {
                                foreach (var group in values.GroupBy(v => v.Id))
                                {
                                    var valueLabels = group.GetValueLabels();

                                    if (attributeFilter != null)
                                    {
                                        facetGroup.FacetType = FacetTypes.Attribute;

                                        var facetResult = facetResults.FirstOrDefault(r => r.Value.ToString().EqualsInvariant(group.Key));
                                        if (facetResult != null)
                                        {
                                            var newFacet = new Facet(facetGroup, group.Key, (int)facetResult.Count, valueLabels);
                                            facetGroup.Facets.Add(newFacet);
                                        }
                                    }

                                    if (rangeFilter != null || priceRangeFilter != null)
                                    {
                                        facetGroup.FacetType = rangeFilter != null ? FacetTypes.Range : FacetTypes.PriceRange;

                                        var rangeFilterValue = group.FirstOrDefault() as RangeFilterValue;
                                        var lower = rangeFilterValue?.Lower == "0" ? null : rangeFilterValue?.Lower;
                                        var upper = rangeFilterValue?.Upper;

                                        var facetResult = facetResults.FirstOrDefault(r => r.From?.ToString() == lower && r.To?.ToString() == upper);
                                        if (facetResult != null)
                                        {
                                            var newFacet = new Facet(facetGroup, group.Key, (int)facetResult.Count, valueLabels);
                                            facetGroup.Facets.Add(newFacet);
                                        }
                                    }
                                }
                            }

                            // Add facet group only if it has items
                            if (facetGroup.Facets.Any())
                            {
                                result.Add(facetGroup);
                            }
                        }
                    }
                }
            }

            return result.ToArray();
        }

        private static DocumentDictionary RenameFields(DocumentDictionary document)
        {
            var result = new DocumentDictionary();

            foreach (var kvp in document)
            {
                var key = AzureQueryHelper.FromAzureFieldName(kvp.Key);
                result[key] = kvp.Value;
            }

            return result;
        }
    }
}