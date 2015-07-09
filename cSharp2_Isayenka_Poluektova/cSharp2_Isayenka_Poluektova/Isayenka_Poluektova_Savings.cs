/*
 * cSharp2_Isayenka_Poluektova.cs
 * The course code: COMP 1202
 * Author: Isayenka, Poluektova
 * This application calculates the closing balance for the client. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  _cSharp2_Isayenka_Poluektova
{
    class Isayenka_Poluektova_Savings
    {
        private string firstName;
        private string lastName;
        private int sin;
        private string homeAddress;
        private string phoneNumber;
        private double openingBalance;
        private double deposit;
        private double closingBalance;

        public Isayenka_Poluektova_Savings()
        {

        }

        public Isayenka_Poluektova_Savings(string fName, string lName, int sinN, string hAddress,
            string pNumber, double oBalance, double dep, double cBalance)
        {
            firstName = fName;
            lastName = lName;
            sin = sinN;
            homeAddress = hAddress;
            phoneNumber = pNumber;
            openingBalance = oBalance;
            deposit = dep;
            closingBalance = cBalance;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int Sin
        {
            get
            {
                return sin;
            }
            set
            {
                sin = value;
            }
        }

        public string HomeAddress
        {
            get
            {
                return homeAddress;
            }
            set
            {
                homeAddress = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public double OpeningBalance
        {
            get
            {
                return openingBalance;
            }
            set
            {
                openingBalance = value;
            }
        }

        public double Deposit
        {
            get
            {
                return deposit;
            }
            set
            {
                deposit = value;
            }
        }
        public double ClosingBalance
        {
            get
            {
                return closingBalance;
            }
            set
            {
                closingBalance = value;
            }
        }
    }
}
