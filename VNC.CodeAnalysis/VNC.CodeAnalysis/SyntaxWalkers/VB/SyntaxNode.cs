using System;

using Microsoft.CodeAnalysis.VisualBasic;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class SyntaxNode : VNCVBSyntaxWalkerBase
    {
        public override void Visit(Microsoft.CodeAnalysis.SyntaxNode node)
        {
            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                Messages.AppendLine(String.Format("{0} >{1}<",
                    GetNodeContext((VisualBasicSyntaxNode)node),
                    node.ToString()));
            }

            base.Visit(node);
        }
    }
}
