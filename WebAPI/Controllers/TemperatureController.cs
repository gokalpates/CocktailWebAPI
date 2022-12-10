using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TemperatureController : ControllerBase
	{
		IGenericService<Temperature> _temperatureManager;

		public TemperatureController(IGenericService<Temperature> manager)
		{
			_temperatureManager = manager;
		}

		[HttpGet]
		public IEnumerable<Temperature> GetAll()
		{
			return _temperatureManager.GetAll();
		}

		[HttpGet("{id}")]
		public Temperature? Get(int id)
		{
			return _temperatureManager.Get(id);
		}

		[HttpPut]
		public void Update(Temperature temperature)
		{
			_temperatureManager.Update(temperature);
		}

		[HttpPost]
		public void Add(Temperature temperature)
		{
			_temperatureManager.Add(temperature);
		}

		[HttpDelete]
		public void Delete(Temperature temperature)
		{
			_temperatureManager.Delete(temperature);
		}

        [HttpDelete("{id}")]
        public void Delete(int id)
		{
            _temperatureManager.Delete(id);
        }
    }
}
