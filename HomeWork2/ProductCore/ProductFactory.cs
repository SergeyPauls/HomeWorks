using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.ProductCore
{

    public static class ProductFactory
    {

        static int curId = 0;

        public static Product GetProduct()
        {
            Product pc = new Product();

            switch (GetNextId())
            {
                case 0:
                    pc = new Product(1, "Одежда и аксессуары");
                    break;
                case 1:
                    pc = new Product(2, "Телефоны и телекоммуникации");
                    break;
                case 2:
                    pc = new Product(3, "Детские товары");
                    break;
                case 3:
                    pc = new Product(4, "Автомобили и мотоциклы");
                    break;
                case 4:
                    pc = new Product(5, "Ювелирные изделия");
                    break;
                default:
                    throw new ArgumentException();
            }

            return pc;

        }

        static int GetNextId()
        {
            curId = ++curId % 5;
            return curId;
        }
    }
}


                

                

                