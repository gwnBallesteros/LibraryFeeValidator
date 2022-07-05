﻿using System;
using static System.Console;

namespace LibraryFee
{
    class LibraryFeeApp
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string studentName;
            string librarianName;
            char classif;

            Header();
            studentName = InputStudentName();
            librarianName = InputNameInCharge();
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
            Console.WriteLine("[D] College");
            Console.WriteLine("===================================================");
            Write("Enter the year level: ");
            yearLevel = Convert.ToChar(ReadLine());
            return yearLevel;
        }

        static public string InputNameInCharge()
        {
            string nameStaff;
            Console.Write("Name of the Librarian: ");
            nameStaff = ReadLine();
            return nameStaff;

        }
    }

}