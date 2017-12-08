using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            studentskaDB databaza = new studentskaDB();
            databaza.loadstudenti();
            Student[] zoradenistudenti;
            databaza.Zorad(databaza.polestudentov, out zoradenistudenti);


            foreach (Student s in zoradenistudenti)
            {
                Console.WriteLine(s.Meno + "  " + s.Priezvisko + "   " + s.Vek);
            }
            Console.WriteLine();
            foreach (Student s in databaza.polestudentov)
            {
                Console.WriteLine(s.Meno + "  " + s.Priezvisko + "   " + s.Vek);
            }
            Console.WriteLine();
            foreach (Student s in databaza.zoznamstudentov)
            {
                Console.WriteLine(s.Meno + "  " + s.Priezvisko + "   " + s.Vek);
            }


            
            int dlzka = (databaza.zoznamstudentov.Count == 4) ? 4 : -1;

            Console.WriteLine();





            kolekce k = new kolekce();

            Console.WriteLine();

            k.naplnfrontu();

            Console.WriteLine();

            k.naplnzasobnik();

            k.naplntabulku();

            



            


            




            Console.ReadLine();



        }
    }
}
