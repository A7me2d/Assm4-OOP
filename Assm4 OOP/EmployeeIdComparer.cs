using Assm4_OOP.ICloneblae_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Emploee? empX = (Emploee?)x;
            Emploee? empY = (Emploee?)y;

            return empX?.Id.CompareTo(empY?.Id) ?? (empY is null ? 0 : -1);
        }

    }
}