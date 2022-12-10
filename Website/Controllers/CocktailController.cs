using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text;
using Website.Models;

namespace Website.Controllers
{
    public class CocktailController : Controller
    {
        public IActionResult Index(int index)
        {
            var client = new HttpClient();

            var endpoint = new Uri("https://localhost:7191/api/Cocktail/" + index.ToString());
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;

            Cocktail? specificCocktail = Newtonsoft.Json.JsonConvert.DeserializeObject<Cocktail?>(json);

            return View(specificCocktail);
        }

        public IActionResult Delete(int index)
        {
            var client = new HttpClient();

            var endpoint = new Uri("https://localhost:7191/api/Cocktail/" + index.ToString());
            client.DeleteAsync(endpoint);

            return View("~/Views/Shared/Index.cshtml");
        }
    }
}
