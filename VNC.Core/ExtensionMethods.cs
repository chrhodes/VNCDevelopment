﻿namespace VNC.Core
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Surrounds string in Double quotes "<string>"</string>
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string WrapInDblQuotes(this string text)
        {
            return WrapIn(text, "\"");
        }

        /// <summary>
        /// Surrounds string in single quotes '<string>'</string>
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string WrapInSngQuotes(this string text)
        {
            return WrapIn(text, "'");
        }

        /// <summary>
        /// Surrounds string in ends <ends><string></ends>"</string>
        /// </summary>
        /// <param name="text"></param>
        /// <param name="ends"></param>
        /// <returns></returns>
        public static string WrapIn(this string text, string ends)
        {
            return ends + text + ends;
        }
    }
}
