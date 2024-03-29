﻿/* 1202W13As1_Poluektova_Anna.cs
 * The course code: COMP 1202
 * Student ID: 100786356
 * Author: Anna Poluektova
 * This application calculates the closing balance for the client. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1202W13As1_Poluektova_Anna
{
    class AnnaPoluektova_Savings
    {
        private string firstName;
        private string lastName;
        private int sin;
        private string homeAddress;
        private string phoneNumber;
        private double openingBalance;
        private double deposit;
        private double closingBalance;

        public AnnaPoluektova_Savings()
        {

        }

        public AnnaPoluektova_Savings(string fName, string lName, int sinN, string hAddress,
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
