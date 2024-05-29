using System;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class SyntaxToken : VNCVBSyntaxWalkerBase
    {
        public override void VisitToken(Microsoft.CodeAnalysis.SyntaxToken token)
        {
            if (_targetPatternRegEx.Match(token.ToString()).Success)
            {
                Messages.AppendLine(String.Format("{0} >{1}<",
                    //GetNodeContext(token),
                    "",
                    token.ToString()));
            }

            base.VisitToken(token);
        }
    }
}
