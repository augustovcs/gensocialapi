namespace GenSocialAPI.Interfaces;

public interface IPostGeneratorService
{
    string GeneratePost(string fixedTextScript, string optionalTextScript ,string styleSelected);
}