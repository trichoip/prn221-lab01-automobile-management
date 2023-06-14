using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carId) => CarManagement.Instance.GetCarByID(carId);
        public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarList();
        public void InsertCar(Car car) => CarManagement.Instance.AddNew(car);
        public void UpdateCar(Car car) => CarManagement.Instance.Update(car);
        public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);
    }
}