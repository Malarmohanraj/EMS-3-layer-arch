using System;

namespace Capgemini.EMS.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dateofjoining { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, " + $"Dateofjoining: {Dateofjoining.ToShortDateString()}";
        }
    }
}
