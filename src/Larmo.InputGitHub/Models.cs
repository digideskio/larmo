namespace Larmo.Input.GitHub.Models
{
    public class Push
    {
        public string Compare { get; set; }

        public static explicit operator Push(string from)
        {
            return new Push
            {
                Compare = "http://test.compare.url.com/xxx"
            };
        }
    }
}
