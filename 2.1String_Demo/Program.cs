﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1String_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo
            string firstName;
            string lastName;
            string occupation;

            firstName = "Mickey";
            lastName = "Mouse";
            occupation = "Stuntman";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);


            //String Interpolation
            Console.WriteLine("Name:{0}" + "\n" + "Occupation:{1}", fullName, occupation);

            //Have them practice with something that they're interested in: gaming, sports, family, etc.
            Console.ReadLine();

        }
    }
}
