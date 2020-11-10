//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SearchPhrase.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace VirtoCommerce.SearchModule.Data.SearchPhraseParsing.Antlr {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISearchPhraseListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class SearchPhraseBaseListener : ISearchPhraseListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.searchPhrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSearchPhrase([NotNull] SearchPhraseParser.SearchPhraseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.searchPhrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSearchPhrase([NotNull] SearchPhraseParser.SearchPhraseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.phrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPhrase([NotNull] SearchPhraseParser.PhraseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.phrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPhrase([NotNull] SearchPhraseParser.PhraseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] SearchPhraseParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] SearchPhraseParser.KeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.filters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilters([NotNull] SearchPhraseParser.FiltersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.filters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilters([NotNull] SearchPhraseParser.FiltersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.attributeFilter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributeFilter([NotNull] SearchPhraseParser.AttributeFilterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.attributeFilter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributeFilter([NotNull] SearchPhraseParser.AttributeFilterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.rangeFilter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeFilter([NotNull] SearchPhraseParser.RangeFilterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.rangeFilter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeFilter([NotNull] SearchPhraseParser.RangeFilterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.fieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldName([NotNull] SearchPhraseParser.FieldNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.fieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldName([NotNull] SearchPhraseParser.FieldNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.attributeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributeFilterValue([NotNull] SearchPhraseParser.AttributeFilterValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.attributeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributeFilterValue([NotNull] SearchPhraseParser.AttributeFilterValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.rangeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeFilterValue([NotNull] SearchPhraseParser.RangeFilterValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.rangeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeFilterValue([NotNull] SearchPhraseParser.RangeFilterValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.range"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRange([NotNull] SearchPhraseParser.RangeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.range"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRange([NotNull] SearchPhraseParser.RangeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.rangeStart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeStart([NotNull] SearchPhraseParser.RangeStartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.rangeStart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeStart([NotNull] SearchPhraseParser.RangeStartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.rangeEnd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeEnd([NotNull] SearchPhraseParser.RangeEndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.rangeEnd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeEnd([NotNull] SearchPhraseParser.RangeEndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.lower"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLower([NotNull] SearchPhraseParser.LowerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.lower"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLower([NotNull] SearchPhraseParser.LowerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.upper"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpper([NotNull] SearchPhraseParser.UpperContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.upper"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpper([NotNull] SearchPhraseParser.UpperContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] SearchPhraseParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] SearchPhraseParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.negation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegation([NotNull] SearchPhraseParser.NegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.negation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegation([NotNull] SearchPhraseParser.NegationContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace VirtoCommerce.SearchModule.Data.SearchPhraseParsing.Antlr
