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

        public CostForm(string sName, string lName, char classifLevel)
        {
            studentName = sName;
            librarianName = lName;
            classif = classifLevel;
        }

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

        public void Classification(char ClassifLevl)
        {
            decimal baseFee = 0;
            decimal setCost = baseFee + MISC_FEE;
            string classificationLevel;
            switch(classif)
            {
                case 'A':
                case 'a':
                    classificationLevel = "Freshman";
                    baseFee = FRESHMAN_FEE;
                    setCost = baseFee + MISC_FEE;
                    break;
                case 'B':
                case 'b':
                    classificationLevel = "Sophomore";
                    baseFee = SOPHOMORE_FEE;
                    setCost = baseFee + MISC_FEE;
                    break;
                case 'C':
                case 'c':
                    classificationLevel = "Junior";
                    baseFee = JUNIOR_FEE;
                    setCost = baseFee + MISC_FEE;
                    break;
                case 'D':
                case 'd':
                    classificationLevel = "Senior";
                    baseFee = SENIOR_FEE;
                    setCost = baseFee + MISC_FEE;
                    break;
                case 'E':
                case 'e':
                    classificationLevel = "COLLEGE";
                    baseFee = COLLEGE_FEE;
                    setCost = baseFee + MISC_FEE;
                    break;
            }

        }

    }
}
