using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Academy_task
{
    public class Teacher : Person
    {
        public Teacher(string? name, string? surname, string? groupID, double salary) : base(name, surname, groupID)
        {
            Salary = salary;
        }

        public double Salary { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
