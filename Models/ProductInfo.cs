using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication117.Models
{
    public class ProductInfo
    {
        public ProductModel Prod { get; set; }
        public List<PhotoModel> Photos { get; set; }
        public List<CallbackModel> Callbacks { get; set; }
    }
}
