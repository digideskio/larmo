using Larmo.Domain.Domain;

namespace Larmo.Infrastructure.DTO
{
    public class ExtraDataDto
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public static explicit operator ExtraDataDto(ExtraData from)
        {
            if (from == null)
            {
                return null;
            }

            return new ExtraDataDto
            {
                Key = from.Key,
                Value = from.Value
            };
        }
    }
}
