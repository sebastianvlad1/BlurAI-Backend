using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlurAI_Backend.Controllers{

    [ApiController]
    [Route("/api/[controller]")]
    public class ImageProcessingController : ControllerBase
    {
        [HttpPost("blurfaces")]
        public IActionResult blurfaces(IFormFile image){
            try{
                Console.WriteLine("filename: " + image.FileName);
                Console.WriteLine("contenttype: " + image.ContentType);
                Console.WriteLine("length: " + image.Length);
                return Ok();
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }

    }
}