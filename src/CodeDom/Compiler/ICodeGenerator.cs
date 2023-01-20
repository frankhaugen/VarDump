// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;
using VarDump.CodeDom.Common;

namespace VarDump.CodeDom.Compiler
{
    internal interface ICodeGenerator
    {
        void GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o);
        void GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o);
    }
}
