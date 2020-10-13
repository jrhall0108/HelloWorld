using HelloWorldApi;
using HelloWorldWriter;
using System.Configuration;


namespace HelloWorldClient
{
    public class HelloWorldClient
    {
        private static IMessageProvider messageProviderService;
        private static MessageProviderServiceLocator msgProviderServiceLocator = new MessageProviderServiceLocator();
        private static MessageWriter messageWriter;

        /// <summary>
        /// Main Entry Point
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) { 

            messageProviderService = msgProviderServiceLocator.LocateMessageService(ConfigurationManager.AppSettings["InputType"]);
            
            messageWriter = MessageWriter.GetMessageWriter(ConfigurationManager.AppSettings["OutputType"]);

            var message = messageProviderService.GetMessage();

            //Console.Write(message);
            messageWriter.Write(message);
        }
    }
}
