using System;
using Larmo.Domain;
using Larmo.Infrastructure.Utilities;

namespace Larmo.Infrastructure
{
    public class TokenGenerator : ITokenGenerator
    {
        public string Generate(string value = "")
        {
            var slug = string.IsNullOrEmpty(value) ? "" : value.GenerateSlug() + "-";
            var token = Guid.NewGuid().ToString();

            return  slug + token;
        }
    }
}
