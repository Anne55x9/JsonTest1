using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Name = "Anne",
                Tlf= 26573928,
                Email = "a@yahoo.com" 
        };

            string jsonText = JsonConvert.SerializeObject(person1);
            Console.WriteLine(jsonText);

            Console.ReadLine();

        }
    }
}
