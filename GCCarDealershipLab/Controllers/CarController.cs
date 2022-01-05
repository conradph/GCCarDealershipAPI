using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCCarDealershipLab.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public List<Car> Cars = new List<Car>() {
            new Car("Ford", "Bronco", 1985, "Red"),
            new Car("Ford", "Escort", 1986, "Blue"),
            new Car("Chevrolet", "Caprice", 1983, "Purple"),
            new Car("Honda", "Accord", 1990, "Grey"),
            new Car("Cadillac", "El Dorado", 1985, "Black"),
            new Car("Lincoln", "Continental", 1985, "Red"),
            new Car("Ford", "Bronco", 1985, "Red"),
            new Car("Ford", "Bronco", 1985, "Red"),
            new Car("Ford", "Bronco", 1985, "Red"),
            new Car("Ford", "Bronco", 1985, "Red"),
        };

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return Cars;
        }
        [HttpGet("/{index}")]
        public Car GetCarByIndex(int index)
        {
            try
            {
                return Cars[index];
            }
            catch
            {
                return null;
            }
        }
        [HttpGet("SearchbyMake/{make}")]
        public List<Car> SearchByMake(string make)
        {
            return Cars.Where(x => x.Make.ToLower() == make.ToLower()).ToList();
        }
        [HttpGet("SearchbyModel/{model}")]
        public List<Car> SearchByModel(string model)
        {
            return Cars.Where(x => x.Model.ToLower() == model.ToLower()).ToList();
        }
        [HttpGet("SearchbyYear/{year}")]
        public List<Car> SearchByYear(int year)
        {
            return Cars.Where(x => x.Year == year).ToList();
        }
        [HttpGet("SearchbyColor/{color}")]
        public List<Car> SearchByColor(string color)
        {
            return Cars.Where(x => x.Color.ToLower() == color.ToLower()).ToList();
        }
        //This is probably not the right way to be doing this but it worked ¯\_(ツ)_/¯
        [HttpGet("delete/{index}")]
        public List<Car> DeleteCar(int index)
        {
            
            Cars.RemoveAt(index);
           
            return Cars;
        }
    }
}
