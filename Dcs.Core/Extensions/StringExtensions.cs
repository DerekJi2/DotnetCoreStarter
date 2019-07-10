using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strA"></param>
        /// <param name="strB"></param>
        /// <returns></returns>
        public static bool EqualsCI(this string strA, string strB)
        {
            return string.Equals(strA, strB, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatWith(this string format, object[] args)
        {
            if (format.IsNullOrEmpty())
            {
                return format;
            }
            return string.Format(format, args);
        }
    }
}
