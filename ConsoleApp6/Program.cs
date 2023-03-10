using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Первая задача
            string shablon_1 = "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])\\." +
                "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])\\." +
                "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])\\." +
                "([0-1][0-9][0-9]|[2][0-5][0-5]|[0-9][0-9]|[0-9])$";
            Console.WriteLine("Entry IPv4");
            string zadanie_1 = Console.ReadLine();
            Regex regeluar_1 = new Regex(shablon_1);
            if (regeluar_1.IsMatch(zadanie_1))
            {
                Console.WriteLine($"Your IP is correct{zadanie_1}");
            }
            else
            {
                Console.WriteLine("You entered an invalid IP, IPv4 example: 192.168.0.9");
            }
            #endregion

            #region Вторая задача   
            string shablon_2 = "а|е|и|ы|ё|о|ю|я|у";
            Console.WriteLine("\nEnter text");
            string zadanie_2 = Console.ReadLine();
            MatchCollection myMatch = Regex.Matches(zadanie_2, shablon_2, RegexOptions.IgnoreCase);
            int count = 0;
            foreach (Match i in myMatch)
                count++;
            Console.WriteLine(count);
            #endregion

            #region Третья задача 
            string shablon_3 = @"https://\w*|http://\w*|";
            Console.WriteLine("Enter URL");
            string zadanie_3 = Console.ReadLine();
            Regex regeluar_3 = new Regex(shablon_3);
            if (regeluar_3.IsMatch(zadanie_3))
            {
                Console.WriteLine($"Your URL is correct");
            }
            else
            {
                Console.WriteLine("You entered an invalid URL");
            }
            #endregion

            #region Четвертая задача
            string shablon_4 = @"^\w{1}$";
            Console.WriteLine("Enter value");
            string zadanie_4 = Console.ReadLine();
            Regex regeluar_4 = new Regex(shablon_4);
            if (regeluar_4.IsMatch(zadanie_4))
            {
                Console.WriteLine($"Your alphanumeric value");
            }
            else
            {
                Console.WriteLine("Your value is not alphanumeric");
            }
            #endregion

            #region Пятая задача 
            string shablon_5 = @"^(([01][0-9])|([2][0-3])):[0-5][0-9]:[0-5][0-9]$";
            Console.WriteLine("Enter time\nExample hours/minutes/seconds");
            string zadanie_5 = Console.ReadLine();
            Regex regeluar_5 = new Regex(shablon_5);
            if (regeluar_5.IsMatch(zadanie_5))
            {
                Console.WriteLine($"Your timing is correct{zadanie_5}");
            }
            else
            {
                Console.WriteLine("Your time is wrong");
            }
            #endregion

            #region Шестая задача
            string shablon_6 = @"[1-8]\d{4}$|[0][1-9]\d{3}$|[9]\d{2}[5][0]$|[9]\d{2}[0-4]\d$";
            Console.WriteLine("Enter US Postcode");
            string zadanie_6 = Console.ReadLine();
            Regex regeluar_6 = new Regex(shablon_6);
            if (regeluar_6.IsMatch(zadanie_6))
            {
                Console.WriteLine($"You have entered a valid US Postcode");
            }
            else
            {
                Console.WriteLine($"You have entered an invalid US Postcode");
            }
            #endregion
        }
    }
}