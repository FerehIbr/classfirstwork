using System;
using System.Collections.Generic;
using System.Text;

namespace classfirstwork
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Positon;
        public int DailySalary;

        public Employee()
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Positon = Positon;
            this.DailySalary = DailySalary;

        }

        public void Monthlysalary()
        {
            int DailySalary = 20;
            int Monthlysalary = DailySalary * 30;
            Console.WriteLine(DailySalary*30);
        }
    }
}
