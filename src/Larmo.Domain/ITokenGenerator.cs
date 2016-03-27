namespace Larmo.Domain
{
    public interface ITokenGenerator
    {
        string Generate(string value = "");
    }
}
