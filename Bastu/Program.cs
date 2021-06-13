using System;

namespace Bastu
{
    class Program
    {
        public static double FahrToCels(int fahr)
        {
            //metoden konverterar fahrenheit till celsius, men även min integer till double
            double cel = ((double)fahr - 32) * 5 / 9;
            return cel;
        }
        public static double FahrToCels()
        {
            //metoden konverterar fahrenheit till celsius, men även min integer till double
            double cel = ((double)fahr - 32) * 5 / 9;
            return cel;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Enter desired temperature in Fahrenheit: ");
            int fahrenheit = 0;
            double celsius = 0;
            int maxTemp = 77;
            int minTemp = 73;

            do
            {
                while (true) //while loop för min undantagshantering så fel input kan anges hur många gånger som helst, utan krasch
                {

                    try
                    {
                        fahrenheit = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Try again: ");
                        
                    }
                }
                if (fahrenheit == celsius)
                {

                }
                celsius = FahrToCels(fahrenheit);
                
                if (celsius < minTemp)
                {
                    Console.WriteLine("Input is too cold! Try again: ");
                }
                else if (celsius > maxTemp)
                {
                    Console.WriteLine("Input is too hot! Try again: ");
                }
                 
            }
            while (celsius < minTemp || celsius > maxTemp);

            celsius = Math.Round(value: (celsius), 0, MidpointRounding.AwayFromZero); //rundar av talet för output. 
            Console.WriteLine("Sauna set at " + fahrenheit + " degrees Fahrenheit. (" + celsius + " degrees Celsius.)");


            Console.ReadKey();


        }
    }
}
