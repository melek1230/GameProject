using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IProduct
    {
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public string ProductNo { get; set; }
        public float SumPrice { get; set; }
    }
}
