﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Force.Crc32;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class VisitAll : VNCCSSyntaxWalkerBase
    {
        public VisitAll(SyntaxWalkerDepth depth = SyntaxWalkerDepth.StructuredTrivia) : base(depth)
        {
        }

        public string GetCRC32()
        {
            byte[] messagesToBytes = asciiEncoding.GetBytes(Messages.ToString());

            return Crc32CAlgorithm.Compute(messagesToBytes).ToString();
        }

        static int tabs = 0;
        const int tabWidth = 2;

        public override void Visit(Microsoft.CodeAnalysis.SyntaxNode node)
        {
            tabs++;

            if (!node.IsKind(SyntaxKind.CompilationUnit))
            {
                var indents = new String(' ', tabs * tabWidth);

                if (_configurationOptions.DisplayFormattedOutput)
                {
                    Messages.AppendLine(string.Format("Node:{0}{1}:>{2}<", indents,
                        _configurationOptions.DisplayNodeKind ? node.Kind().ToString() : "",
                        _configurationOptions.DisplayNodeValue ? node.ToString() : ""));
                }
                else
                {
                    Messages.AppendLine(string.Format("Node:{0}:>{1}<",
                        _configurationOptions.DisplayNodeKind ? node.Kind().ToString() : "",
                        _configurationOptions.DisplayNodeValue ? node.ToString() : ""));
                }
            }

            // Call base to visit children

            base.Visit(node);
            tabs--;
        }

        public override void VisitToken(Microsoft.CodeAnalysis.SyntaxToken token)
        {
            var indents = new String(' ', tabs * tabWidth);

            if (_configurationOptions.DisplayFormattedOutput)
            {
                Messages.AppendLine(string.Format("Token:{0}{1}:>{2}<", indents,
                        _configurationOptions.DisplayNodeKind ? token.Kind().ToString() : "",
                        _configurationOptions.DisplayNodeValue ? token.ToString() : ""));
            }
            else
            {
                Messages.AppendLine(string.Format("Token:{0}:>{1}<",
                        _configurationOptions.DisplayNodeKind ? token.Kind().ToString() : "",
                        _configurationOptions.DisplayNodeValue ? token.ToString() : ""));
            }

            // Call base to visit children

            base.VisitToken(token);
        }

        public override void VisitTrivia(Microsoft.CodeAnalysis.SyntaxTrivia trivia)
        {
            var indents = new String(' ', tabs * tabWidth);

            if (_configurationOptions.DisplayFormattedOutput)
            {
                Messages.AppendLine(string.Format("Trivia:{0}{1}:>{2}<", indents,
                        _configurationOptions.DisplayNodeKind ? trivia.Kind().ToString() : "",
                        _configurationOptions.DisplayNodeValue ? trivia.ToString() : ""));
            }
            else
            {
                Messages.AppendLine(string.Format("Trivia:{0}:>{1}<",
                        _configurationOptions.DisplayNodeKind ? trivia.Kind().ToString() : "",
                        _configurationOptions.DisplayNodeValue ? trivia.ToString() : ""));
            }

            // Call base to visit children

            base.VisitTrivia(trivia);
        }
    }
}
