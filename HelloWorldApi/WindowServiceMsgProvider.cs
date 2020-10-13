using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApi
{
    public class WindowsServiceMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Input from a Windows Service
        /// </summary>
        /// <returns></returns>
        public string GetMessage() => "TODO - Windows Service";

    }
}
