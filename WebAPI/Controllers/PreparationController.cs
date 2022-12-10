using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PreparationController : ControllerBase
	{
		IGenericService<Preparation> _preparationManager;
		public PreparationController(IGenericService<Preparation> manager)
		{
			_preparationManager = manager;
		}

		[HttpGet]
		public IEnumerable<Preparation> GetAll()
		{
			return _preparationManager.GetAll();
		}

		[HttpGet("{id}")]
		public Preparation? Get(int id)
		{
			return _preparationManager.Get(id);
		}

		[HttpPut]
		public void Update(Preparation preparation)
		{
			_preparationManager.Update(preparation);
		}

		[HttpPost]
		public void Add(Preparation preparation)
		{
			_preparationManager.Add(preparation);
		}

		[HttpDelete]
		public void Delete(Preparation preparation)
		{
			_preparationManager.Delete(preparation);
		}

        [HttpDelete("{id}")]
        public void Delete(int id)
		{
            _preparationManager.Delete(id);
        }
    }
}
