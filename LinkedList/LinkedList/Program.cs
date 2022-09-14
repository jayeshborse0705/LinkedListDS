using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linklist operation:");
            Linklist list = new Linklist();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            //list.RemoveFirstNode();
            list.Display();
            list.Search(40);
            list.Display();
            Console.WriteLine("*********************last element delate");
            // list.RemoveLastNode();
            // list.Display();
        }
    }
}
