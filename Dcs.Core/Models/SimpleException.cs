using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Models
{
    public class SimpleException : ISimpleException
    {
        public SimpleException(Exception ex)
        {
            if (ex != null)
            {
                Message = ex.Message;
                StackTrace = ex.StackTrace;
                InnerException = new SimpleException(ex.InnerException);
            }            
        }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public SimpleException InnerException { get; set; }

        public string ErrorString()
        {
            var errBuilder = new StringBuilder();
            var ex = this;
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
