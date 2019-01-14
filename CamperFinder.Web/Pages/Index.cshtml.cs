using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CamperFinder.Web.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            HttpClient _client = new HttpClient();
            
        }
    }
}
