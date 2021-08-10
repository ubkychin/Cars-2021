using System.Collections.Generic;
using CarsLib;
using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController: ControllerBase
    {
        List<Car> carsList;

        public CarsController() {
            this.carsList = new List<Car>();
            this.carsList.Add(new Car("ABC123", 0));
            this.carsList.Add(new Car("CBA321", 150));
            this.carsList.Add(new Car("ZXC789", 10));
            this.carsList.Add(new Car("CXZ987", 100));
        }

        [HttpGet]
        public List<Car> Get() {
            return this.carsList;
        }

        [HttpGet("{rego}")]
        public Car Get(string rego) {
            
            foreach (Car currentCar in this.carsList) {
                if (rego == currentCar.Rego) {
                    return currentCar;
                }
            }

            return null;
        }

    }
}