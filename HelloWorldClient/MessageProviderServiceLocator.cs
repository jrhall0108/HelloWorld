using HelloWorldApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClient
{
    public class MessageProviderServiceLocator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageService"></param>
        /// <returns></returns>
        public IMessageProvider LocateMessageService(string messageService)
        {
            switch (messageService)
            {
                case "MobileApplication":
                    return new MobileAppMsgProvider();
                case "WebApplication":
                    return new WebAppMsgProvider();
                case "ConsoleApplication":
                    return new ConsoleAppMsgProvider();
                case "WindowsService":
                    return new WindowsServiceMsgProvider();
                default:
                    return new ConsoleAppMsgProvider();
            }
        }
    }
}
