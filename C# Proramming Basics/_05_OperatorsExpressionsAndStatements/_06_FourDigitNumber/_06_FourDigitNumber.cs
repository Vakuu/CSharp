using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FourDigitNumber
{
    class _06_FourDigitNumber
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            int suma = int.Parse(numbers[3].ToString()) + int.Parse(numbers[2].ToString()) + int.Parse(numbers[1].ToString()) + int.Parse(numbers[0].ToString());
            string obratnapodredba = numbers[3].ToString() + numbers[2].ToString() + numbers[1].ToString() + numbers[0].ToString();
            string lastfirst = numbers[3].ToString() + numbers[0].ToString() + numbers[1].ToString() + numbers[2].ToString();
            string secondtrird = numbers[0].ToString() + numbers[2].ToString() + numbers[1].ToString() + numbers[3].ToString();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    suma = suma + int.Parse(numbers[i].ToString());
            //    obratnapodredba = numbers[i].ToString() + obratnapodredba;
            //}
            Console.WriteLine(suma);
            Console.WriteLine(obratnapodredba);
            Console.WriteLine(lastfirst);
            Console.WriteLine(secondtrird);
        }
    }
}
