using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                              on ca.ColorId equals co.Id
                             select new CarDetailDto { Id = ca.Id,BrandId=br.Id,ColorId=co.Id, BrandName = br.BrandName, ColorName = co.ColorName, DailyPrice = ca.DailyPrice,
                                 Description=ca.Description,ModelYear=ca.ModelYear };
                return filter == null ? result.ToList()
                                  : result.Where(filter).ToList();
            }
        }
    }
}
