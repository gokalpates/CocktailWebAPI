using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IngredientController : ControllerBase
	{
		IGenericService<Ingredient> _ingredientManager;

		public IngredientController(IGenericService<Ingredient> manager)
		{
			_ingredientManager = manager;
		}

		[HttpGet]
		public IEnumerable<Ingredient> GetAll()
		{
			return _ingredientManager.GetAll();
		}

		[HttpGet("{id}")]
		public Ingredient? Get(int id)
		{
			return _ingredientManager.Get(id);
		}

		[HttpPut]
		public void Update(Ingredient ingredient)
		{
			_ingredientManager.Update(ingredient);
		}

		[HttpPost]
		public void Add(Ingredient ingredient)
		{
			_ingredientManager.Add(ingredient);
		}

		[HttpDelete]
		public void Delete(Ingredient ingredient)
		{
			_ingredientManager.Delete(ingredient);
		}

        [HttpDelete("{id}")]
        public void Delete(int id)
		{
            _ingredientManager.Delete(id);
        }
    }
}
