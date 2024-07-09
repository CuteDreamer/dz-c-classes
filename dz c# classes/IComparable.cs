using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_c__classes
{
    internal interface IComparable
    {
        void SearchStud();
        class InnerClassOne : IComparer
        {
            public void SortStudents()
            {
                Console.WriteLine("Sorting....");
            }
        }
        class InnerClassTwo : IComparer
        {
            public void SortStudents()
            {
                Console.WriteLine("Sorting....");
            }
        }

    }
}
