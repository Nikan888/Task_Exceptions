﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exception
{
    public class Worker
    {
        string firstName;
        string lastName;
        int age;
        string homeAdress;
        string department;
        string post;
        string workPhoneNumber;
        decimal salary;

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public string HomeAdress { get => homeAdress; private set => homeAdress = value; }
        public string Department { get => department; private set => department = value; }
        public string Post { get => post; private set => post = value; }
        public string WorkPhoneNumber { get => workPhoneNumber; private set => workPhoneNumber = value; }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 14)
                {
                    throw new Exception("Age must be more than 13");
                }
                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Salary must be more than 0");
                }
                salary = value;
            }
        }

        public Worker(string firstName, string lastName, int age, string homeAdress,
            string department, string post, string workPhoneNumber, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeAdress = homeAdress;
            Department = department;
            Post = post;
            WorkPhoneNumber = workPhoneNumber;
            Salary = salary;
        }

        public override string ToString()
        {
            return (FirstName + ';' + LastName + ';' + Age + ';' + HomeAdress + ';' + Department
                + ';' + Post + ';' + WorkPhoneNumber + ';' + Salary);
        }
    }
}
