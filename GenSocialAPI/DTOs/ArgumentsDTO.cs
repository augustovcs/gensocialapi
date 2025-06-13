namespace GenSocialAPI.DTOs;

public class ArgumentsDTO
{
    public string FixedTextScript { get; set; }
    public string OptionalTextScript { get; set; }
    public string StyleSelected { get; set; }
    public string ImageUrl { get; set; } = "GenSocialAPI/images/No-Image-Placeholder.svg.png";
}