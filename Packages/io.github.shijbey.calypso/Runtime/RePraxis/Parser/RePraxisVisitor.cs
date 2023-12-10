//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from RePraxis.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419
// Remove warning about CLSCompliancy
#pragma warning disable 3021

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="RePraxisParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface IRePraxisVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="RePraxisParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] RePraxisParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RePraxisParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] RePraxisParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RePraxisParser.sentence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSentence([NotNull] RePraxisParser.SentenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RePraxisParser.assertionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssertionExpr([NotNull] RePraxisParser.AssertionExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RePraxisParser.relationalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpr([NotNull] RePraxisParser.RelationalExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RePraxisParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] RePraxisParser.ConstantContext context);
}