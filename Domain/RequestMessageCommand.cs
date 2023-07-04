using NServiceBus;

namespace Domain
{
    public class RequestMessageCommand:ICommand
    {
        
        public string Message { get; set; }
    }
}
