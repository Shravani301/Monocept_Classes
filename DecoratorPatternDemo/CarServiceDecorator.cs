using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    internal abstract class CarServiceDecorator:ICarService
    {
        protected ICarService carService;

        public CarServiceDecorator(ICarService service)
        {
            carService = service;
        }
        public virtual double GetCost()
        {
            return carService.GetCost();   
        }
    }
}
