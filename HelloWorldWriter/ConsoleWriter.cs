using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldWriter
{
    public class ConsoleWriter : MessageWriter
    {
        /// <summary>
        /// Write message to a console
        /// </summary>
        /// <param name="message"></param>
        public override void Write(string message) => Console.WriteLine(message);
    }
}
