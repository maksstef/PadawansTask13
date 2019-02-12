using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string Surname;
        protected int Age;

        public Employee()
        {

        }

        public Employee(string Surname, int Age)
        {
            this.Age = Age;
            this.Surname = Surname;
        }

        string FirstMethod()
        {
            return Age.ToString();
        }

        public void SecondMethod(string str)
        {
            Surname = str;
        }

        public string ThirdMethod()
        {
            string str = $"Surname: {Surname}, Age: {Age}";
            return str;
        }
    }
}
