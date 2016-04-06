using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Larmo.Input.GitHub.Models
{
    [DataContract]
    public class Page
    {
        [DataMember(Name = "page_name")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "html_url")]
        public string Url { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }
    }
}