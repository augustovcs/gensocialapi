using Microsoft.AspNetCore.Mvc;
using GenSocialAPI.DTOs;
using GenSocialAPI.Interfaces;

namespace GenSocialAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GeneratorController : ControllerBase
{
    private readonly IPostGeneratorService _postGeneratorService;

    public GeneratorController(IPostGeneratorService postGeneratorService)
    {
        _postGeneratorService = postGeneratorService;
    }

    [HttpPost("generate")]
    public IActionResult GeneratePost([FromBody] ArgumentsDTO request)
    {
        try
        {
            var post = _postGeneratorService.GeneratePost(request.FixedTextScript, request.OptionalTextScript, request.StyleSelected);
            return Ok(new { post });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
