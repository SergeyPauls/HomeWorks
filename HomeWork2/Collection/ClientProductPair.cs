using HomeWork2.ClientCore;
using HomeWork2.ProductCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Collection
{
    public class ClientProductPair
    {
        public ClientProductPair()
        { }

        public ClientProductPair(Client Client, Product Product)
        {
            this.Client = Client;
            this.Product = Product;
        }

        /// <summary>
        /// Уникальный номер клиента
        /// </summary>
        public Client Client { set; get; }

        /// <summary>
        /// Имя
        /// </summary>
        public Product Product { set; get; }


        //public override int GetHashCode()
        //{
        //    return Id;
        //}

        //public override bool Equals(object obj)
        //{
        //    Client cl = obj as Client;

        //    if (cl == null) return false;

        //    return cl.Id == this.Id;
        //}
    }
}
