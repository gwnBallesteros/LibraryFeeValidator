using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFee
{
    public class CostForm
    {
        //Fees per year level
        private const decimal FRESHMAN_FEE = 1200.00M;
        private const decimal SOPHOMORE_FEE = 1300.00M;
        private const decimal JUNIOR_FEE = 1700.00M;
        private const decimal SENIOR_FEE = 2000.00M;
        private const decimal COLLEGE_FEE = 3500.00M;
        private const decimal MISC_FEE = 275.00M;

        //Other variables
        string studentName;
        string librarianName;
        char classif;

        public CostForm()
        {

        }

        //Assigning the variables
        public CostForm(string sName, string lName, char classifLevel)
        {
            studentName = sName;
            librarianName = lName;
            classif = classifLevel;
        }

        //To get and stored the value of the inputs
        public string StudentsName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public string LibrarianName
        {
            get
            {
                return librarianName;
            }

            set
            {
                librarianName = value;
            }
        }

        public char ClassifLevel
        {
            get
            {
                return classif;
            }

            set
            {
                classif = value;
            }
        }

        //Calculate the Cost
        public decimal SetCost()
        {
            decimal setCost = 0;
            if (classif == 'A' || classif == 'a')
                setCost = FRESHMAN_FEE + MISC_FEE;
            else if (classif == 'B' || classif == 'b')
                setCost = SOPHOMORE_FEE + MISC_FEE;
            else if (classif == 'C' || classif == 'c')
                setCost = JUNIOR_FEE + MISC_FEE;
            else if (classif == 'D' || classif == 'd')
                setCost = SENIOR_FEE + MISC_FEE;
            else if (classif == 'E' || classif == 'e')
                setCost = COLLEGE_FEE + MISC_FEE;

            return setCost;
        }

        //Return the classification level that going to Display in the Cost Form
        public string ReturnNameOfClassification()
        {
            string classificationLevel;
            switch (classif) //Use the classif variable in the program.cs
            {
                case 'A':
                case 'a':
                    classificationLevel = "Freshman";
                    break;
                case 'B':
                case 'b':
                    classificationLevel = "Sophomore";
                    break;
                case 'C':
                case 'c':
                    classificationLevel = "Junior";
                    break;
                case 'D':
                case 'd':
                    classificationLevel = "Senior";
                    break;
                case 'E':
                case 'e':
                    classificationLevel = "COLLEGE";
                    break;
                default:
                    classificationLevel = "UNKNOWN";
                    break;

            }
            return classificationLevel;
        }

        //Display the Cost Form
        public override string ToString()
        {
            return " =================================================== " + 
                "\n                      Cost Form                    " +
                "\n =================================================== " +
                "\n Name of the Student: " + studentName +
                "\n Year Level: " + ReturnNameOfClassification() +
                "\n Overall Fee: " + SetCost() +
                "\n =================================================== " +
                "\n" + "\n Validated by: " + librarianName +
                "\n =================================================== ";
        } 


    }
}
