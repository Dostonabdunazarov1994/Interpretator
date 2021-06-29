namespace Lab4.Ast.Statements {
	class ArrayAssignment : IStatement {
		public readonly IExpression Array;
		public readonly IExpression Left;
		public readonly IExpression Right;
		public readonly IExpression Expr;
		public string FormattedString => $"{Array.FormattedString}[{Left.FormattedString}:{Right.FormattedString}] = {Expr.FormattedString};\n";
		public ArrayAssignment(IExpression array, IExpression left, IExpression right, IExpression expr) {
			Array = array;
			Left = left;
			Right = right;
			Expr = expr;
		}
		public void Accept(IStatementVisitor visitor) => visitor.VisitArrayAssignment(this);
		public T Accept<T>(IStatementVisitor<T> visitor) => visitor.VisitArrayAssignment(this);
	}
}
