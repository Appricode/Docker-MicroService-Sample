using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResolverController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public ResolverController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"Resolver");
            
            
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri($"http://ms{id}/");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Ok(result);
            }

            return null;
        }
    }
}
