﻿using ConsoleProject.Business.Exceptions;
using ConsoleProject.Business.Helpers;
using ConsoleProject.Business.Interfaces;
using ConsoleProject.Core.Entities;
using ConsoleProjetc.DataAccess.Implementations;

namespace ConsoleProject.Business.Services;

public class EmployeeService : IEmployeeInterface
{
    EmployeeRepository employeeRepository { get; }
    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();
    }
    public void Create(Employee employee)
    {
        if (employee.Name.Trim().Length < 2)
        {
            throw new SizeException(Helper.Error["SizeException"]);
        }
        if (!employee.Name.Trim().IsOnlyLetters())
        {
            throw new PatternDoesNotMatchException(Helper.Error["PatternDoesNotMatchException"]);
        }
        if (!string.IsNullOrWhiteSpace(employee.Surname.Trim()))
        {
            if (!employee.Surname.Trim().IsOnlyLetters())
            {
                throw new PatternDoesNotMatchException(Helper.Error["PatternDoesNotMatchException"]);
            }
        }
        if (employee.Salary <= 0)
        {
            throw new CannotBeLessThanZeroException(Helper.Error["CannotBeLessThanZeroException"]);
        }
        employeeRepository.Add(employee);
    }
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
    public void Update(string oldName, string newName, double salary, int id, int departmentId)
    {
        throw new NotImplementedException();
    }
    public List<Employee> GetAll()
    {
        throw new NotImplementedException();
    }

    public Employee GetById(int id)
    {
        throw new NotImplementedException();
    }

}
