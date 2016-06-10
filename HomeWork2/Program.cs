using HomeWork2.ClientCore;
using HomeWork2.ProductCore;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        // Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции.
        // Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей.


        static void Main(string[] args)
        {
            var list = new Dictionary<Client, Product>();

            // Наполняем коллекцию
            for (int i = 0; i < 9; i++)
            {
                list.Add(ClientFactory.GetClient(), ProductFactory.GetProduct());
            }

            // Выводим на просмотр
            Console.WriteLine("Все покупки");

            foreach (var item in list)
            {
                var cl = item.Key;
                var pc = item.Value;

                Console.WriteLine(cl.Name + " - " + pc.Name);
            }

            Console.WriteLine(new string('-', 25));

            // Категории товаров (дистинкт)

            Console.WriteLine("Покупки совершены в категориях:");
            var dpc = new List<Product>();

            //list.Values.(ValueType => value)

            foreach (var item in list.Values)
            {
                if (!dpc.Contains(item)) dpc.Add(item);
            }

            foreach (var item in dpc)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(new string('-', 25));

            var oneClient = ClientFactory.GetClient();

            // Категории товаров для конкретного клиента
            Console.WriteLine("Клиент \"{0}\" совершил покупки в категориях:", oneClient.Name);

            foreach (var item in list)
            {
                if (item.Key.Id == oneClient.Id) Console.WriteLine(item.Value.Name); 
            }



            Console.ReadKey();

        }
    }
}
