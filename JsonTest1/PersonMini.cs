using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest1
{
    class PersonMini
    {

        private string name1;

        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }

  

        public PersonMini()
        {

        }

        public override string ToString()
        {
            return $"{this.name1}";
        }

    }
}
