using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentDB
{
    class kolekce
    {
        // FIFO - first in first out 
        Queue fronta = new Queue();

        Stack zasobnik = new Stack();

        //Hashtable 
        Hashtable tabulka = new Hashtable();

        public void naplnfrontu()
        {
            fronta.Enqueue("Pavel");
            fronta.Enqueue("Pepa");
            fronta.Enqueue("Jano");

            string s = (string)fronta.Dequeue();

            foreach (string d in fronta)
            {
                Console.WriteLine(d);
            }


        }
        public void naplnzasobnik()
        {
            zasobnik.Push(5);
            zasobnik.Push(10);
            zasobnik.Push("pavel");
            zasobnik.Push("Peter");

            string s = zasobnik.Pop().ToString();


        }
        public void naplntabulku()
        {
            tabulka["Pavel Sanca"] = "878378302302";
            tabulka["jasnhjd"] = "4543563656";
            tabulka["j"] = "ddddddd";
            tabulka.Remove("j");

            Console.WriteLine();
        }






    }
}
