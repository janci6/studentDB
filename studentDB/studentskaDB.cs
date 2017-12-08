using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentDB
{
    class studentskaDB
    {
        string[] Meno = new string[5] {"Jano","Ignac","Gejza","Ferenc","Jozef" };
        string[] Priezvisko = new string[5] {"Schwarz","Rumel","Rash","Janci","Durchwartzctinghardmen" };

        public Student[] polestudentov= new Student[10]; // takto zoberies vsetky veci zo student lebo vracia aj string aj int 
        public ArrayList zoznamstudentov = new ArrayList();

        public void loadstudenti ()
        {
            Random nahodnecislo = new Random();
            for (int i = 0; i < 10; i++)
            {
                Student student;
                student.Meno = Meno[nahodnecislo.Next(Meno.Length)];
                student.Priezvisko = Priezvisko[nahodnecislo.Next(Priezvisko.Length)];
                student.Vek = nahodnecislo.Next(15, 80);

                polestudentov[i] = student;
                zoznamstudentov.Add(student);
                
            }
        }
        public bool Zorad(Student[] polestudentov, out Student[] zoradenepole)
        {
            bool BoloTriedene = false;
            zoradenepole =(Student[]) polestudentov.Clone();
            for (int i = 0; i < zoradenepole.Length; i++)
            {
                for(int j = 0; j < zoradenepole.Length -1; j++)
                {
                    if (zoradenepole[j].Vek> zoradenepole[j + 1].Vek)
                    {
                        Student tempStudent = zoradenepole[j + 1];
                        zoradenepole[j + 1] = zoradenepole[j];
                        zoradenepole[j] = tempStudent;
                        BoloTriedene = true;
                    }
                        
                } 
            }
            return BoloTriedene;

        }
        

    }

}
