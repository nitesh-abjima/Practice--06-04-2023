using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();
        int len = str.Length;
        for (int i = 0; i < len; i++)
        {
            for (int j = i; j < len; j++)
            {

                Console.Write(str.Substring(i, (j - i) + 1) + ",");
            }
            Console.WriteLine();

        }


        // assign sunday to meetingDay
        Weekdays meetingDay = Weekdays.sunday;

        Console.WriteLine(meetingDay);

        // convert string value "Spade" to integer value using type casting

        int myCard = (int)Cards.Spade;

        Console.WriteLine("Integer value of string constant is: " + myCard);

        // type casting enum to int
        int planet1 = (int)Planet.mercury;
        int planet2 = (int)Planet.venus;
        int planet3 = (int)Planet.earth;

        Console.WriteLine("Value of first member: " + planet1);
        Console.WriteLine("Value of second member: " + planet2);
        Console.WriteLine("Value of third member: " + planet3);

        // expression lambda 
        var square = (int num) => num * num;

        Console.WriteLine("Square of number: " + square(5));

        // statement lambda 
        var resultingSum = (int a, int b) =>
        {
            int calculatedSum = a + b;
            return calculatedSum;
        };

        Console.WriteLine("Total sum: " + resultingSum(5, 6));

        //Passing Parameter in Method
        
        int[] numbers = { 2, 13, 1, 4, 13, 5 };

        // lambda expression as method parameter
        // returns the total count of 13 in the numbers array
        int totalCount = numbers.Count(x => x == 13);

        Console.WriteLine("Total number of 13: " + totalCount);
    }
}

// define an enum 
enum Weekdays
{
    sunday,
    monday,
    tuesday,
}

//Enum Conversion
enum Cards
{
    Diamond = 1,
    Spade = 2,
    Club = 3,
    Heart = 4,
}

//Enum Default Values
enum Planet
{
    // value is 0
    mercury,
    // value is 1
    venus,
    // value is 2
    earth
}