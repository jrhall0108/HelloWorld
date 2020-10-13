using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApi
{
    public class ConsoleAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Input from a Console App
        /// </summary>
        /// <returns></returns>
        public string GetMessage() => "Hello World";

    }
}
