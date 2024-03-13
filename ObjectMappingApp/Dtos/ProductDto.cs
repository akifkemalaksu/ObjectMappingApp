using ObjectMappingApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectMappingApp.Dtos;
using System.Security.Principal;

namespace ObjectMappingApp.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        public short ModelYear { get; set; }

        public decimal ListPrice { get; set; }
        public BrandDto Brand { get; set; }
        public CategoryDto Category { get; set; }
    }

    public class BrandDto
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }
    }
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
