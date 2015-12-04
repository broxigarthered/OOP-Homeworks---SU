using System;
using System.Collections.Generic;
using CompanyHierarcy;
using CompanyHierarcy.Interfaces;

interface IManager : IEmployee
{
    List<Employee> Employees { get; set; }
}