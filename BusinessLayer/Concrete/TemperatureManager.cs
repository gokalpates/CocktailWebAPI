using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class TemperatureManager : IGenericService<Temperature>
	{
		readonly ITemperatureDAL _temperatureDAL;

		public TemperatureManager(ITemperatureDAL temperatureDAL)
		{
			_temperatureDAL = temperatureDAL;
		}

		public void Add(Temperature temperature)
		{
			_temperatureDAL.Add(temperature);
		}

		public void Delete(Temperature temperature)
		{
			_temperatureDAL.Delete(temperature);
		}

        public void Delete(int item)
        {
            _temperatureDAL.Delete(item);
        }

        public Temperature? Get(int id)
		{
			return _temperatureDAL.Get(id);
		}

		public List<Temperature> GetAll()
		{
			return _temperatureDAL.GetAll();
		}

		public void Update(Temperature temperature)
		{
			_temperatureDAL.Update(temperature);
		}
	}
}
