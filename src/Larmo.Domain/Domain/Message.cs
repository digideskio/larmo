using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Larmo.Domain.Domain
{
    public class Message
    {
        [AutoIncrement]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [References(typeof(Author))]
        public int AuthorId { get; set; }
        [Reference]
        public Author Author { get; set; }

        public int InputId { get; set; }
        public string InputType { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
        [Reference]
        public List<ExtraData> ExtraData { get; set; }
    }
}