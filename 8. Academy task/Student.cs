using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Academy_task
{
    public class Student : Person
    {
        public Student(string? name, string? surname, string? groupID,double score) : base(name, surname, groupID)
        {
            Score = score;
        }

        public double Score { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Score: {Score}");
        }
    }
}
