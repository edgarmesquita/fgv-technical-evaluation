using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FGV.TechnicalEvaluation.Foundation.Helpers
{
    public static class PropertiesHelper
    {
        private const string PropertiesQueryStringDelimeter = ".";

        public static string BuildColumnNameFromMemberExpression(MemberExpression memberExpr)
        {
            var sb = new StringBuilder();
            Expression expr = memberExpr;
            while (true)
            {
                string piece = GetExpressionMemberName(expr, ref expr);
                if (string.IsNullOrEmpty(piece)) break;
                if (sb.Length > 0)
                    sb.Insert(0, PropertiesQueryStringDelimeter);
                sb.Insert(0, piece);
            }
            return sb.ToString();
        }

        private static string GetExpressionMemberName(Expression expr, ref Expression nextExpr)
        {
            if (expr is MemberExpression)
            {
                var memberExpr = (MemberExpression)expr;
                nextExpr = memberExpr.Expression;
                return memberExpr.Member.Name;
            }
            if (expr is BinaryExpression && expr.NodeType == ExpressionType.ArrayIndex)
            {
                var binaryExpr = (BinaryExpression)expr;
                string memberName = GetExpressionMemberName(binaryExpr.Left, ref nextExpr);
                if (string.IsNullOrEmpty(memberName))
                    throw new InvalidDataException("Cannot parse your column expression");
                return string.Format("{0}[{1}]", memberName, binaryExpr.Right);
            }
            return string.Empty;
        }
    }
}
