using System;
class _01_
{
    public static int getIntNumber(string msg)
    {
        Console.Write(msg);
        string first_String = Console.ReadLine();
        int first_real = 0;
        try
        {
            first_real = int.Parse(first_String);
        }
        catch (FormatException)
        {
            Console.WriteLine("'{0}' is not in a valid format.", first_String);
            first_real = getIntNumber("Enter the number again: ");
        }
        catch (OverflowException)
        {
            Console.WriteLine("{0} is outside the range of a float.", first_String);
            first_real = getIntNumber("Enter the number again: ");
        }
        return first_real;
    }
    static void Main(string[] args)
    {
        int WeightInPounds = getIntNumber("");
        double WeightInKg = WeightInPounds / 2.2d;
        int HeightInInches = getIntNumber("");
        double HeightInCm = HeightInInches * 2.54d;
        int Age = getIntNumber("");
        string Gender = Console.ReadLine();
        double BMR = 0;
        if (Gender == "m")
        {
            BMR = 66.5d + (13.75d * WeightInKg) + (5.003d * HeightInCm) - (6.755d * Age);
        }
        else
        {
            BMR = 655 + (9.563d * WeightInKg) + (1.850d * HeightInCm) - (4.676d * Age);
        }
        int WorkoutsPerWeek = getIntNumber("");
        double DCI = 0;
        if (WorkoutsPerWeek < 1)
        {
            DCI = 1.2d * BMR;
        }
        else
            if (WorkoutsPerWeek < 4)
            {
                DCI = 1.375d * BMR;
            }
            else
                if (WorkoutsPerWeek < 7)
                {
                    DCI = 1.55d * BMR;
                }
                else
                    if (WorkoutsPerWeek < 10)
                    {
                        DCI = 1.725d * BMR;
                    }
                    else
                    {
                        DCI = 1.9d * BMR;
                    }
        long result = (long)DCI;
        if (result < 0)
            result = result - 1;
        Console.WriteLine(result);
    }
}
