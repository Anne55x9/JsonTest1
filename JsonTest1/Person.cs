using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest1
{
    class Person
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private int tlf;

        public int Tlf
        {
            get { return tlf; }
            set { tlf = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person()
        {

        }

    }
}
