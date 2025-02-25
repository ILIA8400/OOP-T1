using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string nationalCode;
        public required string NationalCode 
        { 
            get => nationalCode; 
            set 
            {
                if (IsValidateNationalCode(value))
                    nationalCode = value;
                else throw new ArgumentException();
            }
        }
        public string FullName { get => $"{FirstName} {LastName}"; }

        public double BaseSalary { get; protected set; }
        public int Level { get; protected set; }
        public int ExtraTime { get; protected set; }
        public int TotalHours { get; protected set; }

        private bool IsValidateNationalCode(string nationalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalCode) || nationalCode.Length != 10)
                return false;

            if (!nationalCode.All(char.IsDigit))
                return false;

            string[] invalidCodes = { "0000000000", "1111111111", "2222222222", "3333333333", "4444444444",
                                  "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };
            if (invalidCodes.Contains(nationalCode))
                return false;

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (nationalCode[i] - '0') * (10 - i);
            }

            int remainder = sum % 11;
            int controlDigit = nationalCode[9] - '0';

            if ((remainder < 2 && controlDigit == remainder) || (remainder >= 2 && controlDigit == (11 - remainder)))
                return true;

            return false;
        }

        public void SetData(double baseSalary, int level, int totalHours, int extraTime)
        {
            BaseSalary = baseSalary;
            Level = level;
            TotalHours = totalHours;
            ExtraTime = extraTime;
        }

        public abstract double Salary();
        
    }
}
