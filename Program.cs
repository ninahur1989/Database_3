using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Database_3
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
               // 1
                IQueryable<Employee> employeeQuery = context.Employees;
                var employees = employeeQuery
                  .Select(p => p.HiredDate)
                  .ToList();
                List<TimeSpan> list1 = new List<TimeSpan>();
                foreach (var a in employees)
                {
                    list1.Add(DateTime.Now - a);
                }

                context.SaveChanges();
                //2
                context.UpdateRange(context.Clients.Where(x => x.Password == 1 || x.Password == 123));
                context.SaveChanges();
                //3

                var emp2 = new Employee()
                {
                    TitleId = 1,
                    HiredDate = DateTime.Now,
                    DateOfBirthday = DateTime.Now,
                    FirstName = "sda",
                    LastName = "dor",
                    OfficeId = 1
                };

                var emp1 = new Employee()
                {
                    TitleId = 1,
                    HiredDate = DateTime.Now,
                    DateOfBirthday = DateTime.Now,
                    FirstName = "tsG",
                    LastName = "vc",
                    OfficeId = 1
                };

                context.AddRange(emp1, emp2);
                context.SaveChanges();
                //4
                context.Remove(context.Employees.Single(x => x.FirstName == "sa"));
                context.SaveChanges();
                //5
                var employe = context.Titles;
                foreach (var user in employe)
                {
                    context
                       .Entry(user)
                       .Reference(b => b.Employees)
                       .Query();
                }

                employe.GroupBy(x => x.Name).Where(x => !x.Equals("a"));
                foreach (var a in employe)
                {
                    Console.WriteLine(a);
                }

                //6
                var emplOffice = context.Offices.ToList();
                foreach(var emp in emplOffice)
                {
                    Console.WriteLine($"{emp.Id} = {emp.Location} = {emp.Ttitle} -  {emp.Employee?.LastName} - {emp.Employee?.FirstName} - {emp.Employee.Id} - {emp.Employee.HiredDate} - {emp.Employee.DateOfBirthday}");
                }

            }


            Console.WriteLine("Hello World!");
        }
    }
}