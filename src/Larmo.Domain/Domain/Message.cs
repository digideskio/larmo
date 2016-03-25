namespace Larmo.Domain.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public Input Input { get; set; }
    }
}