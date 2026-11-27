using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Academy_task
{
    public class Person
    {
        public Person(string? name, string? surname, string? groupID)
        {
            Name = name;
            Surname = surname;
            GroupID = groupID;
        }

        public string? ID { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? GroupID { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"GroupID: {GroupID}");
        }
    }
}
