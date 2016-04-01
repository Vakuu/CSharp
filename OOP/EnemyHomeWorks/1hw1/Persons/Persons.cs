using System;

namespace Persons
{
    class Persons
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 20, "pesho.ivanov@gmail.com");
            pesho.PrintPersonInfo();

            Person gosho = new Person("Gosho", 35);
            gosho.PrintPersonInfo();
        }
    }
}
