// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace VarDump.CodeDom.Common
{
    internal class CodeSeparatedExpressionCollection : CodeExpression
    {
        public string Separator { get; }
        public CodeExpressionCollection ExpressionCollection { get; }

        public CodeSeparatedExpressionCollection(CodeExpressionCollection value, string separator)
        {
            Separator = separator;
            ExpressionCollection = new CodeExpressionCollection(value);
        }

        public CodeSeparatedExpressionCollection(CodeExpression[] value, string separator)
        {
            ExpressionCollection = new CodeExpressionCollection(value);
            Separator = separator;
        }
    }
}
