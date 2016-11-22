﻿using System;
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

            Person person2 = new Person();
            person2 = JsonConvert.DeserializeObject<Person>(jsonText);

            Console.WriteLine($"{person2.ToString()}");

            List<Person> personListe = new List<Person>();
            personListe.Add(person1);
            personListe.Add(person1);
            personListe.Add(person1);
            personListe.Add(person1);
            personListe.Add(person1);

            string jsontextListe = JsonConvert.SerializeObject(personListe);

            Console.WriteLine("Nu ser vi personlisten:");
            Console.WriteLine(jsontextListe);

            List<Person> listePerson2 = new List<Person>();
            listePerson2 = JsonConvert.DeserializeObject<List<Person>>(jsontextListe);

            foreach (var person in listePerson2)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadLine();

        }
    }
}
