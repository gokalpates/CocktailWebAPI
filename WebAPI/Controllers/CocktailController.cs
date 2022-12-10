using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CocktailController : ControllerBase
	{
		IGenericService<Cocktail> _cocktailManager;

		public CocktailController(IGenericService<Cocktail> manager)
		{
			_cocktailManager = manager;
		}

		[HttpGet]
		public IEnumerable<Cocktail> GetAll()
		{
			return _cocktailManager.GetAll();
		}

		[HttpGet("{id}")]
		public Cocktail? Get(int id) 
		{
			return _cocktailManager.Get(id);
		}

		[HttpPut]
		public void Update(Cocktail cocktail) 
		{
			_cocktailManager.Update(cocktail);
		}

		[HttpPost]
		public void Add(Cocktail cocktail) 
		{
			_cocktailManager.Add(cocktail);
		}

		[HttpDelete]
		public void Delete(Cocktail cocktail) 
		{
			_cocktailManager.Delete(cocktail);
		}

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _cocktailManager.Delete(id);
        }
    }
}
