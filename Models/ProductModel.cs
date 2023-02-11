using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication117.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Hot { get; set; }
        public int Rate { get; set; }
        public string MainPhoto { get; set; }
    }
}
