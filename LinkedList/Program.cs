using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addElements = new AddingElementsToLinkedList();
            addElements.SaveElementToLinkedList("CleanUp|P=0");
            addElements.SaveElementToLinkedList("WashTheCar|P=0");
            addElements.SaveElementToLinkedList("GoToTraning|P=1");
            addElements.SaveElementToLinkedList("WashTheWindow|P=0");
            addElements.SaveElementToLinkedList("EatDinner|P=1");
            addElements.SendComunicate();
            Console.ReadKey();
        }
    }
}
