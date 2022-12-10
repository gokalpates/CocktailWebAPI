using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GlassController : ControllerBase
	{
		IGenericService<Glass> _glassManager;
		public GlassController(IGenericService<Glass> manager)
		{
			_glassManager = manager;
		}

		[HttpGet]
		public IEnumerable<Glass> GetAll()
		{
			return _glassManager.GetAll();
		}

		[HttpGet("{id}")]
		public Glass? Get(int id)
		{
			return _glassManager.Get(id);
		}

		[HttpPut]
		public void Update(Glass glass)
		{
			_glassManager.Update(glass);
		}

		[HttpPost]
		public void Add(Glass glass)
		{
			_glassManager.Add(glass);
		}

		[HttpDelete]
		public void Delete(Glass glass)
		{
			_glassManager.Delete(glass);
		}

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _glassManager.Delete(id);
        }
    }
}
