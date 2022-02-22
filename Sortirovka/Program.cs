﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
            var selectedPeople = from p in people
                                 where p.ToUpper().StartsWith("T")
                                 orderby p
                                 select p;

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
