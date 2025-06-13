using GenSocialAPI.Controllers;
using GenSocialAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class GeneratorService : IPostGeneratorService
{
    private static readonly string[] AllowedStyles = new[] { "cartoon", "vintage", "corporative", "string" };

    public string GeneratePost(string fixedTextScript, string optionalTextScript, string styleSelected)
    {
        if (string.IsNullOrWhiteSpace(fixedTextScript))
            throw new ArgumentException("Fixed text script is required.", nameof(fixedTextScript));

        if (string.IsNullOrWhiteSpace(styleSelected) || !AllowedStyles.Contains(styleSelected.ToLower()))
            throw new ArgumentException("Invalid or missing style.", nameof(styleSelected));

        var combinedText = fixedTextScript;
        if (!string.IsNullOrWhiteSpace(optionalTextScript))
        {
            combinedText += " " + optionalTextScript;
        }

        return ApplyStyle(combinedText, styleSelected.ToLower());
    }

    private string ApplyStyle(string text, string style)
    {
        return style switch
        {
            "cartoon" => $"😂 [Cartoon] {text} 😂",
            "vintage" => $"❤️ [Vintage] {text} ❤️",
            "corporative" => $"📈 [Corporative] {text} 📈",
            "string" => $"<UNK> [String] {text} <UNK>",
            _ => text,
        };
    }
}