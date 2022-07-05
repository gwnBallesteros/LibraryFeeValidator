using System;
using static System.Console;

namespace LibraryFee
{
    class LibraryFee
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string studentName;
            char classif;

            Header();
            studentName = InputStudentName();
            classif = InputYearLevel();
        }

        static void Header()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.WriteLine("                     LIBRARY FEE                   ");
            Console.WriteLine("                      VALIDATOR                    ");
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        public static string InputStudentName()
        {
            string stuNumber;

            Write("Name of the Student: ");
            stuNumber = ReadLine();
            return stuNumber;
        }

        static public char InputYearLevel()
        {
            char yearLevel;

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine("                    YEAR LEVELS                    ");
            Console.WriteLine("===================================================");
            Console.WriteLine("[A] Freshmen");
            Console.WriteLine("[B] Sophomore");
            Console.WriteLine("[C] Junior");
            Console.WriteLine("[A] Senior");
            Console.WriteLine("===================================================");
            Write("Enter the year level: ");
            yearLevel = Convert.ToChar(ReadLine());
            return yearLevel;
        }
    }

}