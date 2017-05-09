using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiseInterfaceJsonNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = SerialiseProduct();
            Console.WriteLine(json);

            IProduct product = DeserialiseProduct(json);
            Console.WriteLine(product.Id);
            
            Console.ReadLine();

        }

        private static IProduct DeserialiseProduct(string json)
        {
            IProduct product = JsonConvert.DeserializeObject<IProduct>(json);

            return product;
        }

        private static string SerialiseProduct()
        {
            IProduct product = new Product()
            {
                Id = 1,
                UnitPrice = 12.3m
            };

            string json = JsonConvert.SerializeObject(product);
            return json;
        }
    }
}
