﻿using System;

namespace Patterns_Practices_Principles.Principles.SOLID.Liskov_substitution_principle
{
    /// This principle is simple but very important to understand.
    /// Child class should not break parent class’s type definition and behavior.
    /// Now what is the meaning of this!! Ok let me take the same employee example to make you understand this principle.
    /// Check the below picture.
    /// Employee is a parent class and Casual and Contractual employee are the child classes, inhering from employee class.
    ///
    /// Now see the below code:
    public abstract class EmployeeLS
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }

        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }

    public class CasualEmployee : EmployeeLS
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }

    public class ContractualEmployee : EmployeeLS
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }

    //Up to this is fine right? Now, check the below code and it will violate the LSP principle.

    //List<Employee> employeeList = new List<Employee>();
    //employeeList.Add(new ContractualEmployee());
    //employeeList.Add(new CasualEmployee());
    //foreach (Employee e in employeeList)
    //{
    //e.GetEmployeeDetails(1245);
    //}

    //Now I guess you got the problem.Yes right, for contractual employee,
    //you will get not implemented exception and that is violating LSP.
    //Then what is the solution? Break the whole thing in 2 different interfaces,
    //1. IProject
    //2. IEmployee
    //and implement according to employee type.

    // public interface IEmployee
    //{
    //string GetEmployeeDetails(int employeeId);
    //}

    //public interface IProject
    //{
    //    string GetProjectDetails(int employeeId);
    //}

    // Now, contractual employee will implement IEmployee not IProject.This will maintain this principle.
}