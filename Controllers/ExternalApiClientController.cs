using Microsoft.AspNetCore.Mvc;

namespace CRUD.API.Controllers
{
    [Route("api/[controller]")]
    public class ExternalApiClientController : ControllerBase
    {

        [HttpGet("CallApi")]
        public async Task<string> CallApi()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.boredapi.com/api/");

                using (HttpResponseMessage response = await client.GetAsync("activity"))
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    response.EnsureSuccessStatusCode();


                    
                    return responseContent;
                }
            }
        }

      
    }
}