using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementationAnyMethod.Solutions
{
    public enum EmployeeType
    {
        Unknown = 0,
        FullTime = 1,
        Contractor = 2,
        Intern = 3
    }

    public class SampleClass
    {
        //Using Count() enumerates the entire collection to compute the count
        public void BadSampleMethod(IEnumerable<EmployeeType> employees)
        {
            if (employees is null || employees.Count() == 0)
            {
                return;

                // other implementations
            }
        }

        //Using Any() method is faster and more readable
        public void GoodSampleMethod(IEnumerable<EmployeeType> employees)
        {
            if (employees is null || !employees.Any())
            {
                return;
            }
        }
    }
}
