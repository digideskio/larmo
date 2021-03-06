﻿using System;
using System.Collections.Generic;
using System.Linq;
using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class MessageDto
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Input { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public AuthorDto Author { get; set; }
        public IEnumerable<ExtraDataDto> ExtraData;

        public static explicit operator MessageDto(Message from)
        {
            return new MessageDto
            {
                Id = from.Id,
                Timestamp = from.Timestamp,
                Input = from.InputType,
                Url = from.Url,
                Content = from.Content,
                Author = (AuthorDto)from.Author,
                ExtraData = from.ExtraData?.Select(ed => (ExtraDataDto)ed)
            };
        }
    }
}