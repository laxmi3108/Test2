using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class StudentDetails
    {
        private int rollno;
        private string name;
        private string course;
        private int paidfee;
        private static double Stax = 12.3;

        public StudentDetails()
        {
            Console.WriteLine("Enter rollno");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter course");
            course = Console.ReadLine();



        }
        public void Payment(int amount)
        {
            paidfee += amount;
        }
        public void print()
        {
            Console.WriteLine(paidfee);
        }
        public int DueAmount
        {
            get { return TotalFee - paidfee; }
        }
        public int TotalFee
        {
            get
            {
                double total = course == "C#" ? 2000 : 3000;
                total = total + total * Stax / 100;
                return (int)total;
            }
        }
        public static double ServiceTax
        {
            get { return Stax; }
            set { Stax = value; }
        }
    }
    class Student
    {

        public static void Main()
        {
            StudentDetails s1 = new StudentDetails();
            s1.Payment(1000);
            s1.print();
            Console.WriteLine(s1.DueAmount);

            Console.ReadKey();

        }
    }
}
