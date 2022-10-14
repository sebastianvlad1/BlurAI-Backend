using System;
using System.IO;
using System.Net.Http.Headers;
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
                MemoryStream destination = new MemoryStream();
                image.CopyTo(destination);
                byte[] byteArray = destination.ToArray();
                return new FileContentResult(byteArray, "application/octet-stream");
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }

    }
}