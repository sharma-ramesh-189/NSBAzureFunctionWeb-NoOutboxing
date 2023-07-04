using Domain;
using NServiceBus;
using NServiceBus.Logging;
using System.Threading.Tasks;

namespace ASBFunctionTrigger
{
    public class RequestMessageHandler : IHandleMessages<RequestMessageCommand>
    {
        static readonly ILog Log = LogManager.GetLogger<RequestMessageHandler>();
        public Task Handle(RequestMessageCommand message, IMessageHandlerContext context)
        {
            Log.Info($"Recieved Message: {message.Message}");
            Log.Warn($"Handling {nameof(RequestMessageCommand)} in {nameof(RequestMessageHandler)}");
            return context.Reply(new ResponseMessage { Message="This message is reply for request messsage."});
        }
    }
}
