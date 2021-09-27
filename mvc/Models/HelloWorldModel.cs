using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace asp.net.mvc.Models
{
    public class HelloWorldModel
    {
        public string HelloWorld { get; set; }
 
        public HelloWorldModel()
        {
            HelloWorld = GetHelloWorldAsync().Result;
        }

        public HttpClient CreateHelloWorldClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/HelloWorldApi");
            return client;
        }

        public async Task<String> GetHelloWorldAsync()
        {
            using (var client = CreateHelloWorldClient())
            {
                HttpResponseMessage response;
                response = client.GetAsync(client.BaseAddress).Result;

                if (response.IsSuccessStatusCode)
                {
                    var helloworld = await response.Content.ReadAsStringAsync();
                    return helloworld;
                }
                else
                {
                    return "??";
                }
            }
        }
    }
}
