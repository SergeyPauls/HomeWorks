using HomeWork2.ClientCore;
using HomeWork2.Collection;
using HomeWork2.ProductCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork2
{
    // Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции.
    // Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей.
    public class ClientProductList : IList<ClientProductPair>
    {
        // список пар клиент-продукт
        private List<ClientProductPair> coll = new List<ClientProductPair>();

        public ClientProductPair this[int index]
        {
            get { return coll[index]; }
            set { coll[index] = value; }
        }
        
        /// <summary>
        /// Возвращает количесво пар клиент-товар 
        /// </summary>
        public int Count
        { get { return coll.Count(); } }

        /// <summary>
        /// Для чтения и записи
        /// </summary>
        public bool IsReadOnly
        { get { return false; } }

        /// <summary>
        /// Добавляет пару клиент-товар в конец коллекции
        /// </summary>
        /// <param name="item"></param>
        public void Add(ClientProductPair item)
        { coll.Add(item); }

        /// <summary>
        /// Добавляет пару клиент-товар в конец коллекции
        /// </summary>
        /// <param name="Client">Клиент</param>
        /// <param name="Product">Продукт</param>
        public void Add(Client Client, Product Product)
        { coll.Add(new ClientProductPair(Client, Product)); }

        /// <summary>
        /// Удаляет все пары
        /// </summary>
        public void Clear()
        { coll.Clear(); }

        /// <summary>
        /// Определяет входит ли пара в состав
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(ClientProductPair item)
        { return coll.Contains(item); }

        /// <summary>
        /// Копирует ClientProductPair целиком в совместимый одномерный массив, начиная с указанного индекса коннечного массива
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(ClientProductPair[] array, int arrayIndex)
        { coll.CopyTo(array, arrayIndex); }

        public IEnumerator<ClientProductPair> GetEnumerator()
        { return coll.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator()
        { return coll.GetEnumerator(); }

        public int IndexOf(ClientProductPair item)
        { return coll.IndexOf(item); }

        public void Insert(int index, ClientProductPair item)
        { coll.Insert(index, item); }

        public bool Remove(ClientProductPair item)
        { return coll.Remove(item); }

        public void RemoveAt(int index)
        { coll.RemoveAt(index); }

        /// <summary>
        /// Возвращает список Product-элементов, которые купил покупатель
        /// </summary>
        /// <param name="Client"></param>
        /// <returns></returns>
        public List<Product> GetProducts(Client Client)
        {
            var l = new List<Product>();

            if (Client == null) return l;

            foreach (var item in coll)
            {
                if (Client.Equals(item.Client))
                {
                    if (!l.Contains(item.Product)) l.Add(item.Product);
                }
            }

            return l;
        }

        /// <summary>
        /// Возвращает список Client-элементов, которые купили товар
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public List<Client> GetClients(Product Product)
        {
            var l = new List<Client>();

            if (Product == null) return l;

            foreach (var item in coll)
            {
                if (Product.Equals(item.Product))
                {
                    if (!l.Contains(item.Client)) l.Add(item.Client);
                }
            }

            return l;
        }

    }
}
