using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Musteri
    {
        private string id;
        private string name;
        private string surname;
        private string creditRating;

        public string Id{ get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string CreditRating { get { return creditRating; } set { creditRating = value; } }

    }
}
