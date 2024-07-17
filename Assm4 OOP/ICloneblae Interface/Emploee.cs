using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.ICloneblae_Interface
{
    internal class Emploee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public Emploee(Emploee emploee)
        {
            Id = emploee.Id;
            Name = emploee.Name;
            Salary = emploee.Salary;
        }
          public Emploee()
        {
            
        }
        public object Clone()
        {
            return new Emploee(this);
        }

        public override string ToString()
        {
            return $"id = {Id} , Name = {Name} , Salary = {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Emploee PassedEmployees = (Emploee)obj;
            if (this.Salary > PassedEmployees.Salary)
                return 1;
            else if (this.Salary < PassedEmployees.Salary)
                return -1;
            else
                return 0;

        }
    }
}
