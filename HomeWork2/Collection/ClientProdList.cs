using HomeWork2.ClientCore;
using HomeWork2.ProductCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    // Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции.
    // Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей.
    public class ClientProdList : IDictionary<Client, Product>
    {
        // Коллекция клиентов
        private List<Client> clients = new List<Client>();

        private List<Product> products = new List<Product>();

        readonly ClientsComparer comparer = new ClientsComparer();

        public Product this[Client key]
        {
            get
            {
                int i = FindClient(key);
                if (i >= 0) return products[i];
                throw new KeyNotFoundException();
                //return default(Product);
            }
            set
            {
                int i = FindClient(key);
                if (i >= 0) products[i] = value;
            }
        }

        private int FindClient(Client key)
        {
            if (key == null) { throw new ArgumentNullException(key.Name); }

            if (clients == null) return -1;

            for (int i = 0; i < clients.Count - 1; i++)
            {
                if (comparer.Compare(clients[i], key) == 0) return i;
            }

            return -1;
        }

        private sealed class ClientsComparer : IComparer<Client>
        {
            // Проверяет равенство двух клиентов без учета регистра строк.
            readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

            public int Compare(Client x, Client y) { return comparer.Compare(x, y); }

        }

        public int Count
        { get { return clients.Count(); } }

        public bool IsReadOnly
        { get { return false; } }

        public ICollection<Client> Keys
        { get { return clients; } }

        public ICollection<Product> Values
        { get { return products; } }

        public void Add(KeyValuePair<Client, Product> item)
        {
            Add(item.Key, item.Value);
        }

        /// <summary>
        /// Добавляет пару Client-Product в конец коллекции
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(Client key, Product value)
        {
            clients.Add(key);
            products.Add(value);
        }

        public void Clear()
        {
            clients.Clear();
            products.Clear();
        }

        public bool Contains(KeyValuePair<Client, Product> item)
        {
            // Не уверен, что именно так. Пока пропускаю.
            for (int i = 0; i < clients.Count - 1; i++)
            {
                if (clients[i] == item.Key || products[i] == item.Value) return true;
            }
            return false;
        }

        public bool ContainsKey(Client key)
        {
            return FindClient(key) >= 0;
        }

        public void CopyTo(KeyValuePair<Client, Product>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<Client, Product>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<Client, Product> item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Client key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(Client key, out Product value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
