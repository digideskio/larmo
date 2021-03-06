﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Larmo.Infrastructure.Utilities
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string phrase, int maxLength = 100)
        {
            var str = phrase.RemoveAccent().ToLower();

            // Invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");

            // Convert multiple spaces into one dash
            str = Regex.Replace(str, @"\s+", "-");
            
            // Replace double occurences of - or \_ 
            str = Regex.Replace(str, @"([-_]){2,}", "$1");

            // Trim
            str = str.Trim();

            // Cut
            str = str.Substring(0, str.Length <= maxLength ? str.Length : maxLength);

            return str;
        }

        public static string RemoveAccent(this string txt)
        {
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return Encoding.ASCII.GetString(bytes);
        }
        public static string Join(this IEnumerable<string> strings, string separator)
        {
            return string.Join(separator, strings.ToArray());
        }

        public static string UppercaseFirst(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            return char.ToUpper(value[0]) + value.Substring(1);
        }
    }
}
