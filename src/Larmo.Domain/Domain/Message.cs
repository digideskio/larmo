using System;

namespace Larmo.Domain.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int AuthorId { get; set; }
        public int InputId { get; set; }
        public string InputType { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
    }
}