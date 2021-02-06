using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=180,Description="Araç hakkında:\nAbs: var\nYakıt: dizel\nVites: manuel\nCamlar: analog\nklima: yok"},
                new Car {CarId=2,BrandId=2,ColorId=2,ModelYear=1999,DailyPrice=100,Description="Araç hakkında:\nAbs: yok\nYakıt: benzin\nVites: manuel\nCamlar: analog\nklima: yok"},
                new Car {CarId=3,BrandId=3,ColorId=3,ModelYear=2010,DailyPrice=210,Description="Araç hakkında:\nAbs: yok\nYakıt: dizel\nVites: otomatik\nCamlar: dijital\nklima: var"},
                new Car {CarId=4,BrandId=2,ColorId=3,ModelYear=2015,DailyPrice=260,Description="Araç hakkında:\nAbs: var\nYakıt: dizel\nVites: manuel\nCamlar: dijital\nklima: var"},
                new Car {CarId=5,BrandId=4,ColorId=1,ModelYear=2020,DailyPrice=350,Description="Araç hakkında:\nAbs: var\nYakıt: elektrik\nVites: otomatik\nCamlar: dijital\nklima: var"}
            };
        }

        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _Cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _Cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car> GetById()
        {
            return _Cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}