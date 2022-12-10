using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ColorController : ControllerBase
	{
		IGenericService<Color> _colorManager;

		public ColorController(IGenericService<Color> manager)
		{
			_colorManager = manager;
		}

		[HttpGet]
		public IEnumerable<Color> GetAll() 
		{
			return _colorManager.GetAll();
		}

		[HttpGet("{id}")]
		public Color? Get(int id)
		{
			return _colorManager.Get(id);
		}

		[HttpPut]
		public void Update(Color color)
		{
			_colorManager.Update(color);
		}

		[HttpPost]
		public void Add(Color color)
		{
			_colorManager.Add(color);
		}

		[HttpDelete]
		public void Delete(Color color)
		{
			_colorManager.Delete(color);
		}

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _colorManager.Delete(id);
        }
    }
}
