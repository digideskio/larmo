using System;

namespace Larmo.Domain.Commands
{
    public class AddNewMessage : ICommand
    {
        public readonly string ProjectToken;
        public readonly AddNewMessageInput Input;
        public readonly AddNewMessageAuthor Author;
        public readonly string Content;
        public readonly string Url;
        public readonly DateTime Timestamp;

        public AddNewMessage(string projectToken, AddNewMessageInput input, AddNewMessageAuthor author, string content, string url, DateTime timestamp)
        {
            ProjectToken = projectToken;
            Input = input;
            Author = author;
            Content = content;
            Url = url;
            Timestamp = timestamp;
        }
    }

    public class AddNewMessageAuthor
    {
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }

    public class AddNewMessageInput
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Name.ToLower() + "." + Type.ToLower(); // @todo move to Domain.Message
        }
    }
}