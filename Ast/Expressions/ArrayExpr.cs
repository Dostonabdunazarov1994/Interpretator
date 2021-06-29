using System.Collections.Generic;
using System.Linq;
namespace Lab4.Ast.Expressions {
	class ArrayExpr : IExpression {
		public int Position { get; }
		public IReadOnlyList<IExpression> Items;
		public ArrayExpr(IReadOnlyList<IExpression> items) {
			Items = items;
		}
		public string FormattedString => $"[{string.Join(",", Items.Select(x => x.FormattedString))}]";
		public void Accept(IExpressionVisitor visitor) => visitor.VisitArrayExpr(this);
		public T Accept<T>(IExpressionVisitor<T> visitor) => visitor.VisitArrayExpr(this);
	}
}
