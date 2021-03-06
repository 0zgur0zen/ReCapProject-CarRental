﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsDetails();    
        IDataResult<Car> GetById(int Id);
        IDataResult<List<CarDetailDto>> GetAllCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetAllCarsByColorId(int colorId);
    }
}
