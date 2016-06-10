using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.ClientCore
{

    public static class ClientFactory
    {
        static int curId = 0;

        public static Client GetClient()
        {
            Client cl = new Client();

            //Random rand = new Random();

            //switch (rand.Next(1, 4))
            switch (GetNextId())
            {
                case 0:
                    cl = new Client(1, "ООО Ромашка");
                    break;
                case 1:
                    cl = new Client(2, "ООО Рога и копыта");
                    break;
                case 2:
                    cl = new Client(3, "ИП Сидоров");
                    break;
                default:
                    throw new ArgumentException();
            }

            return cl;

        }

        static int GetNextId()
        {
            curId = (curId+1) % 3;
            return curId;
        }
    }
}
