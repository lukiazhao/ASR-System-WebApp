using System.Collections.Generic;
using System.Linq;
using Dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Angular.Models
{
    public class EmployeeDataAccessLayer
    {
        private readonly s3681602Context db = new s3681602Context();

        public IEnumerable<Employee> GetAllEmployee()
        {
            return db.Employee.ToList();
        }

        // To Add new employee record.
        public int AddEmployee(Employee employee)
        {
            db.Employee.Add(employee);
            db.SaveChanges();
            return 1;
        }

        // To Update the records of a particular employee.
        public int UpdateEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return 1;
        }

        // Get the details of a particular employee.
        public Employee GetEmployeeData(int id)
        {
            var employee = db.Employee.Find(id);
            return employee;
        }

        // To Delete the record of a particular employee.
        public int DeleteEmployee(int id)
        {
            var emp = db.Employee.Find(id);
            db.Employee.Remove(emp);
            db.SaveChanges();
            return 1;
        }

        // To Get the list of Cities.
        public List<City> GetCities()
        {
            return db.City.ToList();
        }
    }
}
