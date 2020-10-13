using System;

namespace HelloWorldApi
{
    public interface IMessageProvider
    {
        /// <summary>
        /// Get the message
        /// </summary>
        /// <returns></returns>
        string GetMessage();
    }
}
