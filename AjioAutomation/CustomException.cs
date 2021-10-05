using System;
using System.Collections.Generic;
using System.Text;

namespace AjioAutomation
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION, CLASS_NOT_FOUND, METHOD_NOT_fOUND, webDriverException, NoSuchElement
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
