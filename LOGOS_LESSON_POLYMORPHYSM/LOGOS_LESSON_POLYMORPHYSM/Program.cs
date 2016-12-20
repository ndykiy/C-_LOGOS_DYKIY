using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Printer p = new Printer("xerox", 4999);

             p.GetParts();
             p.GetNumberOfParts();
             

            Table t = new Table(123, 500, "germany", "pine");
            Notepad n = new Notepad(124, 50, "italy", 100);
            Chair c = new Chair(125, 400, "portugal", "wood");
            string s=t.Style;
            Console.WriteLine(s);
            


            Person p1 = new Person("Jerronimo Jenkins");
            p1.Print();

            Citizen p2 = new Citizen("Leeroy Jenkons", "Lviv");
            p2.Print();

            Person p3 = new Citizen("kello", "citu1");
            Person p4 = (Person)p2;
            Person p5 = p2 as Person;
            if(p2 is Person)
            {
                Console.WriteLine("yey");
            }
            */

            Person[] p = new Person[10];

            int i = 0;
            int k;
            string s;
            int salary;
            string company;
           for(;i<10;i++)
            {
                Console.WriteLine("0-exit\n1-create new employee\n2-create new employer");
                k = int.Parse(Console.ReadLine());
               
                    if (k == 0)
                    break;
                else if (k == 1) {
                    p[i] = new Employee();
                    s = Console.ReadLine();
                    p[i].SetFullName(s);
                    salary = int.Parse(Console.ReadLine());
                    p[i].SetSalary(salary);
                }
                else
                    if (k == 2) {
                    p[i] = new Employer();
                    s = Console.ReadLine();
                    p[i].SetFullName(s);
                    company = Console.ReadLine();
                    p[i].SetCompany(company);
                }
                }
                for (int j = 0; j <=i; j++)
                {
                    Console.WriteLine(j + " " + p[j].fullName);
                }

            }

        }
    }
