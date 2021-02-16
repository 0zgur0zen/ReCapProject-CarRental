using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.Id
                             join v in context.Colors
                              on b.Id equals v.Id
                             select new CarDetailDto { Id = c.Id, BrandName = b.BrandName, ColorName = v.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
