using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CamperFinder.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CamperFinder.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;

        public IndexModel(IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _configuration = configuration;
            _clientFactory = clientFactory;
        }

        public string ApiUri { get; private set; }
        public IEnumerable<Vehicle> Vehicles { get; private set; }
        public bool GetVehicleError { get; set; }

        public async Task OnGet()
        {
            ApiUri = _configuration["MySettings:WebApiBaseUrl"];

            var request = new HttpRequestMessage(HttpMethod.Get, $"{ApiUri}/vehicles");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "HttpClientFactory");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Vehicles = JsonConvert.DeserializeObject<IEnumerable<Vehicle>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                GetVehicleError = true;
                Vehicles = Array.Empty<Vehicle>();
            }
        }
    }
}
