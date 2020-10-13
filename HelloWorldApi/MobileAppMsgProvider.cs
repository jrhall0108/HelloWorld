using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApi
{
    public class MobileAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Input from a Mobile App
        /// </summary>
        /// <returns></returns>
        public string GetMessage() => "TODO - Mobile Application";

    }
}
