using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApi
{
    public class WebAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Input from a Web app
        /// </summary>
        /// <returns></returns>
        public string GetMessage() => "TODO - Web Application";

    }
}
