using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>() { "umer ", "aahil", "bilal" };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            list.Add("tanfeez");
            list.Add("i am harry");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            list.Insert(3, "moin");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            list.Remove("tanfeez");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            list.RemoveAt(2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");




            Dictionary<string, long> contacts = new Dictionary<string, long>()
             {

                 {"owais",7890987654 },
                 {"mohsin",765456789 },
                 {"ubaid",3456789098 }

             };

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Key + "----" + contact.Value);
            }
            Console.WriteLine("---------------");
            contacts.Add("murtaza sir", 98764563457);
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Key + "----" + contact.Value);
            }

            Console.WriteLine("---------------");


            contacts.Remove("ubaid");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Key + "-----" + contact.Value);
            }


            Console.WriteLine("---------------");


            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Aahil");
            myQueue.Enqueue("umar");
            myQueue.Enqueue("harris");
            myQueue.Enqueue("Kamil");
            myQueue.Enqueue("Sahil");


            Console.WriteLine("Dequeuing elements:");
            int B = myQueue.Count;

            for (int i = 0; i < B; i++)
            {
                string element = myQueue.Dequeue();
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");




            Stack<string> stack1 = new Stack<string>();
            stack1.Push("moin");
            stack1.Push("ahmad");
            stack1.Push("basit");
            stack1.Push("Umar");
            stack1.Push("sahil");
            Console.WriteLine("------------------");
            foreach (var name in stack1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");
            stack1.Pop();
            foreach (var name in stack1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");
            Console.WriteLine(stack1.Peek());


            string q;
            int c = stack1.Count;

            Console.WriteLine(stack1.Count);
            Console.WriteLine("------------");
            for (int m = 0; m < c; m++)
            {
                q = stack1.Pop();
                Console.WriteLine(q + " removed");
                Console.WriteLine(stack1.Count);
            }

            Console.WriteLine("------------------");

            Hashtable ht = new Hashtable();
            ht.Add("moin", "harris");
            ht.Add(101, "ahmad");
            ht.Add("umar", 18.6);
            foreach (DictionaryEntry a in ht)
            {


                Console.WriteLine(a.Key + "---------------" + a.Value);


            }
            Console.WriteLine("_____");
            ht.Add("cr7", 123456);

            foreach (DictionaryEntry a in ht)
            {


                Console.WriteLine(a.Key + "---------------" + a.Value);


            }
            ht.Remove("umar");
            Console.WriteLine("_____");
            foreach (DictionaryEntry a in ht)
            {


                Console.WriteLine(a.Key + "---------------" + a.Value);

            }



        }
    }
}