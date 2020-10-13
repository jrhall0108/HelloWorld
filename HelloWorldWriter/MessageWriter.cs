namespace HelloWorldWriter
{
    public abstract class MessageWriter
    {
        /// <summary>
        /// Support different types of output choices
        /// </summary>
        /// <param name="messageWriter"></param>
        /// <returns></returns>
        public static MessageWriter GetMessageWriter(string messageWriter)
        {
            switch (messageWriter)
            {
                case "Console":
                    return new ConsoleWriter();
                case "Database":
                    return new DatabaseWriter();
                default:
                    return new ConsoleWriter();
            }
        }

        /// <summary>
        /// Write message to output choice
        /// </summary>
        /// <param name="message"></param>
        public abstract void Write(string message);
    }
}
