using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Website.Models;

namespace Website.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cocktail cocktail)
        {
            var client = new HttpClient();

            var endpoint = new Uri("https://localhost:7191/api/Cocktail");

            string message = cocktail.ToJson();
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            var content = new ByteArrayContent(bytes);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            client.PostAsync(endpoint, content);

            return View("~/Views/Shared/Index.cshtml");
        }
    }
}
