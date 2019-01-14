using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CamperFinder.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ApiUri { get; private set; }

        public void OnGet()
        {
            ApiUri = _configuration["MySettings:WebApiBaseUrl"];
        }
    }
}
