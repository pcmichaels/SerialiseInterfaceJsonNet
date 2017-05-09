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
            IProduct product = new Product()
            {
                Id = 1,
                UnitPrice = 12.3m
            };

            string json = SerialiseProduct(product);
            Console.WriteLine(json);

            IProduct product2 = DeserialiseProduct(json);
            Console.WriteLine(product2.Id);
            
            Console.ReadLine();

        }

        private static IProduct DeserialiseProduct(string json)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ProductConverter());

            IProduct product = JsonConvert.DeserializeObject<IProduct>(json, settings);

            return product;
        }

        private static string SerialiseProduct(IProduct product)
        {
            string json = JsonConvert.SerializeObject(product);
            return json;
        }
    }
}
