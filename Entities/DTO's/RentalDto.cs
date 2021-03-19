using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO_s
{
   public class RentalDto:IDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string BrandName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
