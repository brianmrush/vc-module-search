﻿using System.Collections.Generic;
using System.Text;
using VirtoCommerce.SearchModule.Core.Model.Filters;

namespace VirtoCommerce.SearchModule.Core.Model.Search.Criterias
{
    public abstract class SearchCriteriaBase : ISearchCriteria
    {
        private readonly IList<ISearchFilter> _filters = new List<ISearchFilter>();
        private readonly IList<ISearchFilter> _currentFilters = new List<ISearchFilter>();

        protected SearchCriteriaBase(string documentType)
        {
            DocumentType = documentType;
        }

        public virtual string DocumentType { get; }

        public virtual bool CacheResults { get; set; } = true;

        /// <summary>
        /// Gets or sets the starting record.
        /// </summary>
        /// <value>The starting record.</value>
        public virtual int StartingRecord { get; set; }

        /// <summary>
        /// Gets or sets the records to retrieve.
        /// </summary>
        /// <value>The records to retrieve.</value>
        public virtual int RecordsToRetrieve { get; set; } = 50;

        public virtual SearchSort Sort { get; set; }

        public virtual string Locale { get; set; }

        public virtual string Currency { get; set; }

        /// <summary>
        /// Gets or sets the price lists that should be considered for filtering.
        /// </summary>
        /// <value>
        /// The price lists.
        /// </value>
        public virtual IList<string> Pricelists { get; set; }

        public virtual IList<ISearchFilter> Filters => _filters;

        public virtual IList<ISearchFilter> CurrentFilters => _currentFilters;

        public virtual void Add(ISearchFilter filter)
        {
            if (filter != null)
            {
                _filters.Add(filter);
            }
        }

        public virtual void Apply(ISearchFilter filter)
        {
            if (filter != null)
            {
                _currentFilters.Add(filter);
            }
        }

        /// <summary>
        /// Gets the cache key.
        /// </summary>
        /// <value>
        /// The cache key.
        /// </value>
        public virtual string CacheKey
        {
            get
            {
                var key = new StringBuilder();

                key.Append("_dc:" + DocumentType);
                key.Append("_st:" + StartingRecord);
                key.Append("_en:" + RecordsToRetrieve);
                key.Append("_lc:" + Locale);
                key.Append("_cr:" + Currency);
                if (Sort != null)
                    key.Append("_st:" + Sort);

                // Add active fields
                foreach (var field in Filters)
                {
                    key.Append("_f:" + field.CacheKey);
                }

                return key.ToString();
            }
        }
    }
}
