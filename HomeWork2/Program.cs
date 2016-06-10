using HomeWork2;
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
            var list = new ClientProductList();

            // Наполняем коллекцию
            for (int i = 0; i < 9; i++)
            {
                list.Add(ClientFactory.GetClient(), ProductFactory.GetProduct());
            }

            // Выводим на просмотр
            Console.WriteLine("Все покупки");

            foreach (var cpp in list)
            {
                Console.WriteLine(cpp.Client.Name + " - " + cpp.Product.Name);
            }

            Console.WriteLine(new string('-', 25));

         
            var oneClient = ClientFactory.GetClient();
            var prodList = list.GetProducts(oneClient);

            // Категории товаров для конкретного клиента
            Console.WriteLine("Клиент \"{0}\" совершил покупки в категориях:", oneClient.Name);

            foreach (var item in prodList)
            {
                Console.WriteLine(item.Name); 
            }

            Console.WriteLine(new string('-', 25));

            var oneProduct = ProductFactory.GetProduct();
            var clientList = list.GetClients(oneProduct);

            // Клиенты, которые купили товар
            Console.WriteLine("\"{0}\" купили:", oneProduct.Name);

            foreach (var item in clientList)
            {
                Console.WriteLine(item.Name);
            }



            Console.ReadKey();

        }
    }
}
