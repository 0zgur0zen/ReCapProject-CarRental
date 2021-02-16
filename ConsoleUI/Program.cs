using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //carManager.Add(new Car { BrandId = 4, ColorId = 2, ModelYear = "2002", DailyPrice = 200, Description = "benzin" });
            //carManager.Update(new Car { Id = 1008, BrandId = 4, ColorId = 5, ModelYear = "2002", DailyPrice = 200, Description = "benzin" });
            //carManager.Delete(new Car { Id = 1008 });

            //brandManager.Add(new Brand { BrandName = "Citroen" });
            //brandManager.Update(new Brand { Id=6,BrandName = "AlFa" });
            //brandManager.Delete(new Brand { Id = 6 });

            //colorManager.Add(new Color { ColorName = "Yeşil" });
            //colorManager.Update(new Color { Id=6,ColorName = "Sarı" });
            //colorManager.Delete(new Color { Id=6 });


            //userManager.Add(new User { FirstName = "john", LastName = "smith", Email = "bbb@bbb", Password = "pass" });
            //userManager.Update(new User {Id=1006, FirstName = "john", LastName = "smith", Email = "bbb@bbb", Password = "passworddd" });
            //userManager.Delete(new User { Id = 1006 });

            //customerManager.Add(new Customer { CompanyName = "Amazonxxx", UserId = 1006 });
            //customerManager.Update(new Customer { Id = 7,CompanyName = "Beko", UserId = 1004 });
            //customerManager.Delete(new Customer { Id = 7 });

            //var result = rentalManager.Add(new Rental { CarId = 6, CustomerId = 1, RentDate = new DateTime(2020, 07, 29, 15, 16, 00), ReturnDate = null });
            //Console.WriteLine(result.Message);

            //var result = rentalManager.Update(new Rental { Id = 3, CarId = 2, CustomerId = 2, RentDate = new DateTime(2020, 01, 11, 10, 30, 00), ReturnDate = new DateTime(2020, 01, 15, 15, 00, 00) });
            //Console.WriteLine(result.Message);

            //var result = rentalManager.Delete(new Rental { Id = 3 });
            //Console.WriteLine(result.Message);

            //var result = customerManager.GetAll();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item.CompanyName);
            //}

            //Console.WriteLine(userManager.GetById(2).Message); 


            //var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.Id + "/" + item.BrandName + "/" + item.ColorName + "/" + item.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


        }
    }
}
