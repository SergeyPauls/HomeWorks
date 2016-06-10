using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.ClientCore
{
    public class Client
    {

        public Client()
        { }

        public Client(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        /// <summary>
        /// Уникальный номер клиента
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { set; get; }


        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            return Equals(obj as Client);

        }

        public bool Equals(Client client)
        {
            if (client == null) return false;

            return client.Id == this.Id;
        }

    }
}
