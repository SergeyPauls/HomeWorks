using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.ProductCore
{
    public class Product
    {
        public Product()
        { }

        public Product(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        /// <summary>
        /// Уникальный номер категории товара
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Наименование категории
        /// </summary>
        public string Name { set; get; }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            Product pc = obj as Product;

            if (pc == null) return false;

            return pc.Id == this.Id;
        }
    }
}
