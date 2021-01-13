using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleForTest
{
    public class Person
    {
        public string Name;

        //public void DoSomething()
        //{
        //    Console.WriteLine("My name is " + Name);
        //}

        public static void DoSomething(Person person)
        {
            Console.WriteLine("My name is " + person.Name);
        }
    }

    public static class Extention
    {
        public static void DoSomething(this Person person)
        {
            Console.WriteLine("My name is " + person.Name);
        }
    }
}
