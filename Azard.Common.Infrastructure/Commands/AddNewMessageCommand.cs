using Azard.Common.Infrastructure.Interfaces;
using Azard.Common.Models.DomainModels;

namespace Azard.Common.Infrastructure.Commands
{
    public class AddNewMessageCommand : ICommandValidator
    {
        public string Author { get; set; }
        public string Message { get; set; }

        public AddNewMessageCommand(NewMessage newMessage)
        {
            Author = newMessage.Author;
            Message = newMessage.Message;
        }

        public bool IsValidCommand()
        {
            return !string.IsNullOrEmpty(this.Author) && !string.IsNullOrEmpty(this.Message);
        }
    }
}