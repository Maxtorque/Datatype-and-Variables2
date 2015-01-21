using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            char gender;
            string IDnumber;
            uint uniqueEmployeeNumber;
            
            firstName = "Cvetomir";
            familyName = "Stanev";
            age = 25;
            gender = 'm';
            IDnumber = "626684550";
            uniqueEmployeeNumber = 7023436;
            Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}", firstName, familyName, age, gender, IDnumber, uniqueEmployeeNumber);
        }
    }
}
