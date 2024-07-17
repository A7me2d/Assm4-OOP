using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.ICloneblae_Interface
{
    internal class Emploee : ICloneable
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
    }
}
