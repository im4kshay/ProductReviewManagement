﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-Welcome to the Product Review Management using LINQ-=-=-=-=-=");
            List<ProductReview> list = ProductReviewManagement.AddProductsReview();
            ProductReviewManagement.DisplayeProductsReview(list);
            Console.ReadLine();
        }
    }
}
