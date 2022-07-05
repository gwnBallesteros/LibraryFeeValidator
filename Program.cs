using System;
using static System.Console;

namespace LibraryFee
{
    class LibraryFeeApp
    {
        //Main function
        static void Main(string[] args)
        {
            //Declaring variables
            string studentName;
            string librarianName;
            char classif;
            //decimal SetCost;

            //Calling the functions then assigning it to the variables
            Header();
            studentName = InputStudentName();
            librarianName = InputNameInCharge();
            classif = InputYearLevel();
            //Calling the method
            CostForm studentCostForm = new CostForm(studentName, librarianName, classif);

            Clear();
            WriteLine(studentCostForm);
            ReadKey();
        }

        //Header function
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

        //Function for the Student's Name
        public static string InputStudentName()
        {
            string stuNumber;
            
            Write("Name of the Student: ");
            stuNumber = ReadLine();
            return stuNumber;

        }

        //Function for the input of the year level
        static public char InputYearLevel()
        {
            char yearLevel;

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine("                    YEAR LEVELS                    ");
            Console.WriteLine("===================================================");
            Console.WriteLine("[A] Freshman");
            Console.WriteLine("[B] Sophomore");
            Console.WriteLine("[C] Junior");
            Console.WriteLine("[D] Senior");
            Console.WriteLine("[E] College");
            Console.WriteLine("===================================================");
            Write("Enter the year level: ");
            yearLevel = Convert.ToChar(ReadLine());
            return yearLevel;
        }

        //Inout for the librarian's name
        static public string InputNameInCharge()
        {
            string nameStaff;
            Console.Write("Name of the Librarian: ");
            nameStaff = ReadLine();
            return nameStaff;

        }
    }

}