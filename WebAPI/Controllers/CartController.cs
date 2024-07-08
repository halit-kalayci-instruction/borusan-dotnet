using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    // localhost:8080/api/cart
    [Route("api/[controller]")] // Attribute => 
    [ApiController]
    public class CartController : ControllerBase
    {
        // En az 1 alan farklı olmalı.


        // Sistemden kaynak talep edildiğinde. GET -> Getirmek
        [HttpGet]
        public string SayHi()
        {
            return "Hi";
        }

        // Sisteme yeni kaynak eklenmesi talep edildiğinde. POST => POST
        [HttpPost]
        public string SayGoodbye()
        {
            return "Good Bye";
        }

        // PUT => Sepet eskiden şuydu şu anda bu
        [HttpPut]
        public string Update()
        {
            return "Http PUT";
        }

        // PATCH => 
        [HttpPatch]
        public string UpdateOnly()
        {
            return "Http Patch";
        }
        // DELETE => Kaynak silineceği zaman
        [HttpDelete]
        public string Delete()
        {
            return "Http Delete";
        }
    }
}
