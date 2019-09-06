using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Extensions
{
    public static class ExceptionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static string ErrorLog(this Exception exception)
        {
            var errBuilder = new StringBuilder();
            var ex = exception;
            var prefix = "";

            while (ex != null)
            {
                errBuilder.Append($"{prefix} Error Messeage: {ex.Message}\r\n");
                errBuilder.Append($"{prefix} StackStrace: {ex.StackTrace}\r\n");

                if (ex.InnerException != null)
                {
                    errBuilder.Append($"{prefix} ------------------- Inner Exception -------------------");
                    ex = ex.InnerException;
                    prefix += "\t";
                }
            }

            return errBuilder.ToString();
        }
    }
}
