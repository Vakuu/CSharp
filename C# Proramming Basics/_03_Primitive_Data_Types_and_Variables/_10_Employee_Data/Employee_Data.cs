using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Employee_Data
{
    class Employee_Data
    {
        static void Main(string[] args)
        {
            string First_Name = "Amanda";
            string Last_Name = "Jonson";
            byte Age = 27;
            char Gender = 'f';
            string Personal_ID= "8306112507";//не се знае дали не се допускат букви и как са формирани тези номера, може някой друг номер да съдържа не цифрови символи
            string Unique_Employee_Number = "27563571";//не се знае дали не се допускат букви и как са формирани тези номера, може някой друг номер да съдържа не цифрови символи
            Console.WriteLine("First Name: " + First_Name);
            Console.WriteLine("Last Name: " + Last_Name);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Gender: "+Gender);
            Console.WriteLine("Personal ID: " + Personal_ID);
            Console.WriteLine("Unique Employee Number: "+Unique_Employee_Number);
        }
    }
}
