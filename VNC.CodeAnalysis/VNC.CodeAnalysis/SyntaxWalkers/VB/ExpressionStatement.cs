﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ExpressionStatement : VNCVBSyntaxWalkerBase
    {
        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Expression.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            // Call base to visit children
            base.VisitExpressionStatement(node);
        }
    }
}
