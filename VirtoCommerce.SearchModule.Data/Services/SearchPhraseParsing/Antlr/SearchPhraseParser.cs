//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SearchPhrase.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace VirtoCommerce.SearchModule.Data.Services.SearchPhraseParsing.Antlr {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class SearchPhraseParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		FD=1, VD=2, RD=3, RangeStart=4, RangeEnd=5, String=6, WS=7;
	public const int
		RULE_searchPhrase = 0, RULE_phrase = 1, RULE_keyword = 2, RULE_attributeFilter = 3, 
		RULE_rangeFilter = 4, RULE_fieldName = 5, RULE_attributeFilterValue = 6, 
		RULE_rangeFilterValue = 7, RULE_range = 8, RULE_rangeStart = 9, RULE_rangeEnd = 10, 
		RULE_lower = 11, RULE_upper = 12, RULE_string = 13;
	public static readonly string[] ruleNames = {
		"searchPhrase", "phrase", "keyword", "attributeFilter", "rangeFilter", 
		"fieldName", "attributeFilterValue", "rangeFilterValue", "range", "rangeStart", 
		"rangeEnd", "lower", "upper", "string"
	};

	private static readonly string[] _LiteralNames = {
		null, "':'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "FD", "VD", "RD", "RangeStart", "RangeEnd", "String", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SearchPhrase.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SearchPhraseParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SearchPhraseParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SearchPhraseParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class SearchPhraseContext : ParserRuleContext {
		public PhraseContext[] phrase() {
			return GetRuleContexts<PhraseContext>();
		}
		public PhraseContext phrase(int i) {
			return GetRuleContext<PhraseContext>(i);
		}
		public ITerminalNode[] WS() { return GetTokens(SearchPhraseParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(SearchPhraseParser.WS, i);
		}
		public SearchPhraseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_searchPhrase; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterSearchPhrase(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitSearchPhrase(this);
		}
	}

	[RuleVersion(0)]
	public SearchPhraseContext searchPhrase() {
		SearchPhraseContext _localctx = new SearchPhraseContext(Context, State);
		EnterRule(_localctx, 0, RULE_searchPhrase);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==WS) {
				{
				{
				State = 28; Match(WS);
				}
				}
				State = 33;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 34; phrase();
			State = 39;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 35; Match(WS);
					State = 36; phrase();
					}
					} 
				}
				State = 41;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			}
			State = 45;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==WS) {
				{
				{
				State = 42; Match(WS);
				}
				}
				State = 47;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PhraseContext : ParserRuleContext {
		public KeywordContext keyword() {
			return GetRuleContext<KeywordContext>(0);
		}
		public AttributeFilterContext attributeFilter() {
			return GetRuleContext<AttributeFilterContext>(0);
		}
		public RangeFilterContext rangeFilter() {
			return GetRuleContext<RangeFilterContext>(0);
		}
		public PhraseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_phrase; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterPhrase(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitPhrase(this);
		}
	}

	[RuleVersion(0)]
	public PhraseContext phrase() {
		PhraseContext _localctx = new PhraseContext(Context, State);
		EnterRule(_localctx, 2, RULE_phrase);
		try {
			State = 51;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 48; keyword();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 49; attributeFilter();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 50; rangeFilter();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KeywordContext : ParserRuleContext {
		public ITerminalNode String() { return GetToken(SearchPhraseParser.String, 0); }
		public KeywordContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyword; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterKeyword(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitKeyword(this);
		}
	}

	[RuleVersion(0)]
	public KeywordContext keyword() {
		KeywordContext _localctx = new KeywordContext(Context, State);
		EnterRule(_localctx, 4, RULE_keyword);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 53; Match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AttributeFilterContext : ParserRuleContext {
		public FieldNameContext fieldName() {
			return GetRuleContext<FieldNameContext>(0);
		}
		public ITerminalNode FD() { return GetToken(SearchPhraseParser.FD, 0); }
		public AttributeFilterValueContext attributeFilterValue() {
			return GetRuleContext<AttributeFilterValueContext>(0);
		}
		public AttributeFilterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributeFilter; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterAttributeFilter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitAttributeFilter(this);
		}
	}

	[RuleVersion(0)]
	public AttributeFilterContext attributeFilter() {
		AttributeFilterContext _localctx = new AttributeFilterContext(Context, State);
		EnterRule(_localctx, 6, RULE_attributeFilter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55; fieldName();
			State = 56; Match(FD);
			State = 57; attributeFilterValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RangeFilterContext : ParserRuleContext {
		public FieldNameContext fieldName() {
			return GetRuleContext<FieldNameContext>(0);
		}
		public ITerminalNode FD() { return GetToken(SearchPhraseParser.FD, 0); }
		public RangeFilterValueContext rangeFilterValue() {
			return GetRuleContext<RangeFilterValueContext>(0);
		}
		public RangeFilterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rangeFilter; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterRangeFilter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitRangeFilter(this);
		}
	}

	[RuleVersion(0)]
	public RangeFilterContext rangeFilter() {
		RangeFilterContext _localctx = new RangeFilterContext(Context, State);
		EnterRule(_localctx, 8, RULE_rangeFilter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 59; fieldName();
			State = 60; Match(FD);
			State = 61; rangeFilterValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FieldNameContext : ParserRuleContext {
		public ITerminalNode String() { return GetToken(SearchPhraseParser.String, 0); }
		public FieldNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldName; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterFieldName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitFieldName(this);
		}
	}

	[RuleVersion(0)]
	public FieldNameContext fieldName() {
		FieldNameContext _localctx = new FieldNameContext(Context, State);
		EnterRule(_localctx, 10, RULE_fieldName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63; Match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AttributeFilterValueContext : ParserRuleContext {
		public StringContext[] @string() {
			return GetRuleContexts<StringContext>();
		}
		public StringContext @string(int i) {
			return GetRuleContext<StringContext>(i);
		}
		public ITerminalNode[] VD() { return GetTokens(SearchPhraseParser.VD); }
		public ITerminalNode VD(int i) {
			return GetToken(SearchPhraseParser.VD, i);
		}
		public AttributeFilterValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributeFilterValue; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterAttributeFilterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitAttributeFilterValue(this);
		}
	}

	[RuleVersion(0)]
	public AttributeFilterValueContext attributeFilterValue() {
		AttributeFilterValueContext _localctx = new AttributeFilterValueContext(Context, State);
		EnterRule(_localctx, 12, RULE_attributeFilterValue);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 65; @string();
			State = 70;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==VD) {
				{
				{
				State = 66; Match(VD);
				State = 67; @string();
				}
				}
				State = 72;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RangeFilterValueContext : ParserRuleContext {
		public RangeContext[] range() {
			return GetRuleContexts<RangeContext>();
		}
		public RangeContext range(int i) {
			return GetRuleContext<RangeContext>(i);
		}
		public ITerminalNode[] VD() { return GetTokens(SearchPhraseParser.VD); }
		public ITerminalNode VD(int i) {
			return GetToken(SearchPhraseParser.VD, i);
		}
		public RangeFilterValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rangeFilterValue; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterRangeFilterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitRangeFilterValue(this);
		}
	}

	[RuleVersion(0)]
	public RangeFilterValueContext rangeFilterValue() {
		RangeFilterValueContext _localctx = new RangeFilterValueContext(Context, State);
		EnterRule(_localctx, 14, RULE_rangeFilterValue);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 73; range();
			State = 78;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==VD) {
				{
				{
				State = 74; Match(VD);
				State = 75; range();
				}
				}
				State = 80;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RangeContext : ParserRuleContext {
		public RangeStartContext rangeStart() {
			return GetRuleContext<RangeStartContext>(0);
		}
		public ITerminalNode RD() { return GetToken(SearchPhraseParser.RD, 0); }
		public RangeEndContext rangeEnd() {
			return GetRuleContext<RangeEndContext>(0);
		}
		public ITerminalNode[] WS() { return GetTokens(SearchPhraseParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(SearchPhraseParser.WS, i);
		}
		public LowerContext lower() {
			return GetRuleContext<LowerContext>(0);
		}
		public UpperContext upper() {
			return GetRuleContext<UpperContext>(0);
		}
		public RangeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_range; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterRange(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitRange(this);
		}
	}

	[RuleVersion(0)]
	public RangeContext range() {
		RangeContext _localctx = new RangeContext(Context, State);
		EnterRule(_localctx, 16, RULE_range);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 81; rangeStart();
			State = 85;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 82; Match(WS);
					}
					} 
				}
				State = 87;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			}
			State = 89;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==String) {
				{
				State = 88; lower();
				}
			}

			State = 94;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==WS) {
				{
				{
				State = 91; Match(WS);
				}
				}
				State = 96;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 97; Match(RD);
			State = 101;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 98; Match(WS);
					}
					} 
				}
				State = 103;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			}
			State = 105;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==String) {
				{
				State = 104; upper();
				}
			}

			State = 110;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==WS) {
				{
				{
				State = 107; Match(WS);
				}
				}
				State = 112;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 113; rangeEnd();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RangeStartContext : ParserRuleContext {
		public ITerminalNode RangeStart() { return GetToken(SearchPhraseParser.RangeStart, 0); }
		public RangeStartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rangeStart; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterRangeStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitRangeStart(this);
		}
	}

	[RuleVersion(0)]
	public RangeStartContext rangeStart() {
		RangeStartContext _localctx = new RangeStartContext(Context, State);
		EnterRule(_localctx, 18, RULE_rangeStart);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 115; Match(RangeStart);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RangeEndContext : ParserRuleContext {
		public ITerminalNode RangeEnd() { return GetToken(SearchPhraseParser.RangeEnd, 0); }
		public RangeEndContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rangeEnd; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterRangeEnd(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitRangeEnd(this);
		}
	}

	[RuleVersion(0)]
	public RangeEndContext rangeEnd() {
		RangeEndContext _localctx = new RangeEndContext(Context, State);
		EnterRule(_localctx, 20, RULE_rangeEnd);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 117; Match(RangeEnd);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LowerContext : ParserRuleContext {
		public ITerminalNode String() { return GetToken(SearchPhraseParser.String, 0); }
		public LowerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lower; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterLower(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitLower(this);
		}
	}

	[RuleVersion(0)]
	public LowerContext lower() {
		LowerContext _localctx = new LowerContext(Context, State);
		EnterRule(_localctx, 22, RULE_lower);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 119; Match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UpperContext : ParserRuleContext {
		public ITerminalNode String() { return GetToken(SearchPhraseParser.String, 0); }
		public UpperContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_upper; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterUpper(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitUpper(this);
		}
	}

	[RuleVersion(0)]
	public UpperContext upper() {
		UpperContext _localctx = new UpperContext(Context, State);
		EnterRule(_localctx, 24, RULE_upper);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 121; Match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StringContext : ParserRuleContext {
		public ITerminalNode String() { return GetToken(SearchPhraseParser.String, 0); }
		public StringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_string; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchPhraseListener typedListener = listener as ISearchPhraseListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
	}

	[RuleVersion(0)]
	public StringContext @string() {
		StringContext _localctx = new StringContext(Context, State);
		EnterRule(_localctx, 26, RULE_string);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 123; Match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\t', '\x80', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', '\t', 
		'\xE', '\x4', '\xF', '\t', '\xF', '\x3', '\x2', '\a', '\x2', ' ', '\n', 
		'\x2', '\f', '\x2', '\xE', '\x2', '#', '\v', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\a', '\x2', '(', '\n', '\x2', '\f', '\x2', '\xE', 
		'\x2', '+', '\v', '\x2', '\x3', '\x2', '\a', '\x2', '.', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\x31', '\v', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x5', '\x3', '\x36', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', 'G', '\n', '\b', '\f', 
		'\b', '\xE', '\b', 'J', '\v', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\a', '\t', 'O', '\n', '\t', '\f', '\t', '\xE', '\t', 'R', '\v', '\t', 
		'\x3', '\n', '\x3', '\n', '\a', '\n', 'V', '\n', '\n', '\f', '\n', '\xE', 
		'\n', 'Y', '\v', '\n', '\x3', '\n', '\x5', '\n', '\\', '\n', '\n', '\x3', 
		'\n', '\a', '\n', '_', '\n', '\n', '\f', '\n', '\xE', '\n', '\x62', '\v', 
		'\n', '\x3', '\n', '\x3', '\n', '\a', '\n', '\x66', '\n', '\n', '\f', 
		'\n', '\xE', '\n', 'i', '\v', '\n', '\x3', '\n', '\x5', '\n', 'l', '\n', 
		'\n', '\x3', '\n', '\a', '\n', 'o', '\n', '\n', '\f', '\n', '\xE', '\n', 
		'r', '\v', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x2', '\x2', '\x10', '\x2', 
		'\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', '\x16', 
		'\x18', '\x1A', '\x1C', '\x2', '\x2', '\x2', '~', '\x2', '!', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x35', '\x3', '\x2', '\x2', '\x2', '\x6', '\x37', 
		'\x3', '\x2', '\x2', '\x2', '\b', '\x39', '\x3', '\x2', '\x2', '\x2', 
		'\n', '=', '\x3', '\x2', '\x2', '\x2', '\f', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\xE', '\x43', '\x3', '\x2', '\x2', '\x2', '\x10', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\x12', 'S', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'u', '\x3', '\x2', '\x2', '\x2', '\x16', 'w', '\x3', '\x2', '\x2', '\x2', 
		'\x18', 'y', '\x3', '\x2', '\x2', '\x2', '\x1A', '{', '\x3', '\x2', '\x2', 
		'\x2', '\x1C', '}', '\x3', '\x2', '\x2', '\x2', '\x1E', ' ', '\a', '\t', 
		'\x2', '\x2', '\x1F', '\x1E', '\x3', '\x2', '\x2', '\x2', ' ', '#', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x1F', '\x3', '\x2', '\x2', '\x2', '!', '\"', 
		'\x3', '\x2', '\x2', '\x2', '\"', '$', '\x3', '\x2', '\x2', '\x2', '#', 
		'!', '\x3', '\x2', '\x2', '\x2', '$', ')', '\x5', '\x4', '\x3', '\x2', 
		'%', '&', '\a', '\t', '\x2', '\x2', '&', '(', '\x5', '\x4', '\x3', '\x2', 
		'\'', '%', '\x3', '\x2', '\x2', '\x2', '(', '+', '\x3', '\x2', '\x2', 
		'\x2', ')', '\'', '\x3', '\x2', '\x2', '\x2', ')', '*', '\x3', '\x2', 
		'\x2', '\x2', '*', '/', '\x3', '\x2', '\x2', '\x2', '+', ')', '\x3', '\x2', 
		'\x2', '\x2', ',', '.', '\a', '\t', '\x2', '\x2', '-', ',', '\x3', '\x2', 
		'\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x31', '/', '\x3', '\x2', '\x2', '\x2', 
		'\x32', '\x36', '\x5', '\x6', '\x4', '\x2', '\x33', '\x36', '\x5', '\b', 
		'\x5', '\x2', '\x34', '\x36', '\x5', '\n', '\x6', '\x2', '\x35', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\x34', '\x3', '\x2', '\x2', '\x2', '\x36', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\x38', '\a', '\b', '\x2', '\x2', '\x38', '\a', 
		'\x3', '\x2', '\x2', '\x2', '\x39', ':', '\x5', '\f', '\a', '\x2', ':', 
		';', '\a', '\x3', '\x2', '\x2', ';', '<', '\x5', '\xE', '\b', '\x2', '<', 
		'\t', '\x3', '\x2', '\x2', '\x2', '=', '>', '\x5', '\f', '\a', '\x2', 
		'>', '?', '\a', '\x3', '\x2', '\x2', '?', '@', '\x5', '\x10', '\t', '\x2', 
		'@', '\v', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '\b', '\x2', 
		'\x2', '\x42', '\r', '\x3', '\x2', '\x2', '\x2', '\x43', 'H', '\x5', '\x1C', 
		'\xF', '\x2', '\x44', '\x45', '\a', '\x4', '\x2', '\x2', '\x45', 'G', 
		'\x5', '\x1C', '\xF', '\x2', '\x46', '\x44', '\x3', '\x2', '\x2', '\x2', 
		'G', 'J', '\x3', '\x2', '\x2', '\x2', 'H', '\x46', '\x3', '\x2', '\x2', 
		'\x2', 'H', 'I', '\x3', '\x2', '\x2', '\x2', 'I', '\xF', '\x3', '\x2', 
		'\x2', '\x2', 'J', 'H', '\x3', '\x2', '\x2', '\x2', 'K', 'P', '\x5', '\x12', 
		'\n', '\x2', 'L', 'M', '\a', '\x4', '\x2', '\x2', 'M', 'O', '\x5', '\x12', 
		'\n', '\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 'O', 'R', '\x3', '\x2', 
		'\x2', '\x2', 'P', 'N', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\x3', '\x2', 
		'\x2', '\x2', 'Q', '\x11', '\x3', '\x2', '\x2', '\x2', 'R', 'P', '\x3', 
		'\x2', '\x2', '\x2', 'S', 'W', '\x5', '\x14', '\v', '\x2', 'T', 'V', '\a', 
		'\t', '\x2', '\x2', 'U', 'T', '\x3', '\x2', '\x2', '\x2', 'V', 'Y', '\x3', 
		'\x2', '\x2', '\x2', 'W', 'U', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\x3', 
		'\x2', '\x2', '\x2', 'X', '[', '\x3', '\x2', '\x2', '\x2', 'Y', 'W', '\x3', 
		'\x2', '\x2', '\x2', 'Z', '\\', '\x5', '\x18', '\r', '\x2', '[', 'Z', 
		'\x3', '\x2', '\x2', '\x2', '[', '\\', '\x3', '\x2', '\x2', '\x2', '\\', 
		'`', '\x3', '\x2', '\x2', '\x2', ']', '_', '\a', '\t', '\x2', '\x2', '^', 
		']', '\x3', '\x2', '\x2', '\x2', '_', '\x62', '\x3', '\x2', '\x2', '\x2', 
		'`', '^', '\x3', '\x2', '\x2', '\x2', '`', '\x61', '\x3', '\x2', '\x2', 
		'\x2', '\x61', '\x63', '\x3', '\x2', '\x2', '\x2', '\x62', '`', '\x3', 
		'\x2', '\x2', '\x2', '\x63', 'g', '\a', '\x5', '\x2', '\x2', '\x64', '\x66', 
		'\a', '\t', '\x2', '\x2', '\x65', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'\x66', 'i', '\x3', '\x2', '\x2', '\x2', 'g', '\x65', '\x3', '\x2', '\x2', 
		'\x2', 'g', 'h', '\x3', '\x2', '\x2', '\x2', 'h', 'k', '\x3', '\x2', '\x2', 
		'\x2', 'i', 'g', '\x3', '\x2', '\x2', '\x2', 'j', 'l', '\x5', '\x1A', 
		'\xE', '\x2', 'k', 'j', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\x3', '\x2', 
		'\x2', '\x2', 'l', 'p', '\x3', '\x2', '\x2', '\x2', 'm', 'o', '\a', '\t', 
		'\x2', '\x2', 'n', 'm', '\x3', '\x2', '\x2', '\x2', 'o', 'r', '\x3', '\x2', 
		'\x2', '\x2', 'p', 'n', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\x3', '\x2', 
		'\x2', '\x2', 'q', 's', '\x3', '\x2', '\x2', '\x2', 'r', 'p', '\x3', '\x2', 
		'\x2', '\x2', 's', 't', '\x5', '\x16', '\f', '\x2', 't', '\x13', '\x3', 
		'\x2', '\x2', '\x2', 'u', 'v', '\a', '\x6', '\x2', '\x2', 'v', '\x15', 
		'\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', '\a', '\x2', '\x2', 'x', '\x17', 
		'\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', '\b', '\x2', '\x2', 'z', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '{', '|', '\a', '\b', '\x2', '\x2', '|', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '}', '~', '\a', '\b', '\x2', '\x2', '~', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '!', ')', '/', '\x35', 'H', 'P', 'W', 
		'[', '`', 'g', 'k', 'p',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace VirtoCommerce.SearchModule.Data.Services.SearchPhraseParsing.Antlr
