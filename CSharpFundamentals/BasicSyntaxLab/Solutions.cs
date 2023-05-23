using System.Globalization;

public class Solutions
{
    internal static void RunStudentInfoPro1()
    {
        Console.Write("Name: {0}, Age: {1}, Grade: {2}", Console.ReadLine(),
                                                         Console.ReadLine(),
                                                         Console.ReadLine());
    }

    internal static void RunPassedPro2() 
        => Console.Write(float.Parse(Console.ReadLine()) >= 3.00f ? "Passed!" : "");

    internal static void RunPassedOrFailedPro3()
        => Console.Write(double.Parse(Console.ReadLine()) >= 3.00f ? "Passed!" : "Failed!");

    internal static void RunBackInThirtyMinsPro4()
    {
        var hour = int.Parse(Console.ReadLine());
        var min = int.Parse(Console.ReadLine());
        
        hour += (min + 30 < 60) ? 0 : 1;
        hour = (hour < 24) ? hour : 0;
        min = (min < 30) ? (min + 30) : (min + 30) % 60;

        Console.Write($"{hour}:");
        Console.Write(min < 10 ? "0" : "");
        Console.Write($"{min}");
    }

    internal static void RunMonthPrinterPro5()
    {
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                Console.Write("January");
                break;
            case 2:
                Console.Write("February");
                break;
            case 3:
                Console.Write("March");
                break;
            case 4:
                Console.Write("April");
                break;
            case 5:
                Console.Write("May");
                break;
            case 6:
                Console.Write("June");
                break;
            case 7:
                Console.Write("July");
                break;
            case 8:
                Console.Write("August");
                break;
            case 9:
                Console.Write("September");
                break;
            case 10:
                Console.Write("October");
                break;
            case 11:
                Console.Write("November");
                break;
            case 12:
                Console.Write("December");
                break;
            default:
                Console.Write("Error!");
                break;
        }
    }

    internal static void RunForeignLanguagesPro6()
    {
        switch (Console.ReadLine()?.Trim().ToLower())
        {
            case "usa": 
            case "england": 
                Console.Write("English");
                break;
            case "spain": 
            case "argentina": 
            case "mexico": 
                Console.Write("Spanish");
                break;
            default:
                Console.Write("unknown");
                break;
        }
    }

    internal static void RunTheatrePromotionsPro7()
    {
        string? day = Console.ReadLine()?.Trim().ToLower(); 
        int age = Convert.ToInt32(Console.ReadLine());
        int price = 0;

        switch (day)
        {
            case "weekday":
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    price = 12;
                else if (age > 18 && age <= 64)
                    price = 18;
                break;
            case "weekend":
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    price = 15;
                else if (age > 18 && age <= 64)
                    price = 20;
                break;
            case "holiday":
                if (age >= 0 && age <= 18)
                    price = 5;
                else if (age > 18 && age <= 64)
                    price = 12;
                else if (age > 64 && age <= 122)
                    price = 10;
                break;
        }
        
        Console.Write(price != 0 ? $"{price}$" : "Error!");
    }

    internal static void RunDivisibleByThreePro8()
    {
        for (int i = 3; i <= 100; i += 3)
        {
            Console.WriteLine(i);
        }
    }

    internal static void RunSumOfOddNumbersPro9()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        
        for (int i = 0; i < num; i++)
        {
            sum += 2*i + 1;
            Console.WriteLine(2*i + 1);
        }

        Console.Write("Sum: {0}", sum);
    }

    internal static void RunMultiplicationTablePro10()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", num, i, num*i);
        }
    }

    internal static void RunMultiplicationTable2Pro11()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int start = Convert.ToInt32(Console.ReadLine());
        
        do 
        {
            Console.WriteLine("{0} X {1} = {2}", num, start, num*start);
            start++;
        } while (start < 11);
    }

    internal static void RunEvenNumberPro12()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        
        while (true)
        {
            num = Math.Abs(num);
            
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is: {0}", num);
                break;
            }
            else
            {
                Console.WriteLine("Please enter an even number.");
            }

            num = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal static void RunHolidaysBetweenTwoDaysPro13()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) 
                holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}