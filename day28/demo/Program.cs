using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Product p = new Product();
            Console.WriteLine("Supplier Name is " + p._supplierName);
            p._supplierName = Console.ReadLine();
            Console.WriteLine("Enter the product name");
            p._productName = Console.ReadLine();
            Console.WriteLine("Enter the product id");
            p._id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Product Name is " + p._productName);
            Console.WriteLine("Supplier Name is " + p._supplierName);
            Console.WriteLine("Product Id is " + p._id);


        }
        public class Product
        {


            public string _productName;
            public long _id;
            public string _supplierName;


        }
    }  }
