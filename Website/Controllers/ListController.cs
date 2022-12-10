using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
	public class ListController : Controller
	{
		public IActionResult Index()
		{
			var client = new HttpClient();

			var endpoint = new Uri("https://localhost:7191/api/Cocktail");
			var result = client.GetAsync(endpoint).Result;
			var json = result.Content.ReadAsStringAsync().Result;
			List<Cocktail>? cocktailList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cocktail>>(json);

			return View(cocktailList);
		}
	}
}
