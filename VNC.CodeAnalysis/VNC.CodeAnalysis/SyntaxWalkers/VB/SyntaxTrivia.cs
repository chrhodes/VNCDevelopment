using System;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class SyntaxTrivia : VNCVBSyntaxWalkerBase
    {
        public override void VisitTrivia(Microsoft.CodeAnalysis.SyntaxTrivia trivia)
        {
            var st = trivia.SyntaxTree;
            string s = trivia.ToString();
            var p = trivia.GetLocation();

            if (! String.IsNullOrWhiteSpace(trivia.ToString()))
            {
                if (_targetPatternRegEx.Match(trivia.ToString()).Success)
                {
                    Messages.AppendLine(String.Format("{0} >{1}<",
                        //GetNodeContext(trivia.SyntaxTree),
                        "",
                        trivia.ToString()));
                }                
            }

            // Call base to visit children

            base.VisitTrivia(trivia);
        }
    }
}
