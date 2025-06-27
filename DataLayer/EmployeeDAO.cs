using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
    public class EmployeeDAO
    {
        static List<Employee> employees = new List<Employee>();
        private bool isGenerated = false;
        public List<Employee> GenerateSampleDataset()
        {
            if (isGenerated) {
                return employees;
            }
            employees.Add(new Employee()
            {
                EmployeeID = 1,
                Name = "Nguyen Hoai Nam",
                UserName = "nhn189",
                Password = "123457",
                JobTitle = "Nhan vien ke toan",
                BirthDate = new DateTime(1995, 5, 10),
                HireDate = new DateTime(2020, 1, 15),
                Address = "156 Duong B, Quan 1"
            });

            employees.Add(new Employee()
            {
                EmployeeID = 2,
                Name = "Tran Thai Nguyen",
                UserName = "ttn02",
                Password = "ghfcs",
                JobTitle = "Bao ve truong",
                BirthDate = new DateTime(1988, 8, 22),
                HireDate = new DateTime(2015, 4, 5),
                Address = "22 Nguyen Van A, Quan 3"
            });

            employees.Add(new Employee()
            {
                EmployeeID = 3,
                Name = "Pham Xuan Toan",
                UserName = "Pxt03",
                Password = "1809",
                JobTitle = "Bac si",
                BirthDate = new DateTime(1992, 3, 18),
                HireDate = new DateTime(2018, 6, 20),
                Address = "19 Dinh Bo Linh, Quan 5"
            });

            employees.Add(new Employee()
            {
                EmployeeID = 4,
                Name = "Nguyen Phi Yen",
                UserName = "npy04",
                Password = "22094",
                JobTitle = "Pho Giam Doc",
                BirthDate = new DateTime(1985, 11, 5),
                HireDate = new DateTime(2012, 9, 1),
                Address = "12 Truong Giang, Quan 10"
            });

            employees.Add(new Employee()
            {
                EmployeeID = 5,
                Name = "Le Thi Be",
                UserName = "ltb05",
                Password = "be2209",
                JobTitle = "Lao Cong",
                BirthDate = new DateTime(1990, 2, 28),
                HireDate = new DateTime(2019, 2, 10),
                Address = "67 Dien bien phu, Binh Thanh"
            });
            isGenerated = true;
            return employees;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public bool AddEmployee(Employee employee)
        {
            Employee e = employees.FirstOrDefault(emp => emp.EmployeeID == employee.EmployeeID);
            if (e != null)
            {
                return false;
            }

            employees.Add(employee);
            return true;
        }
        public bool RemoveEmployee(int employeeId)
        {
            Employee e = employees.FirstOrDefault(emp => emp.EmployeeID == employeeId);
            if (e == null)
            {
                return false;
            }

            employees.Remove(e);
            return true;
        }

        public Employee SearchEmployee(int employeeId)
        {
            return employees.FirstOrDefault(emp => emp.EmployeeID == employeeId);
        }

        // Cap nhat thong tin nhan vien
        public bool UpdateEmployee(Employee employee)
        {
            Employee e = employees.FirstOrDefault(emp => emp.EmployeeID == employee.EmployeeID);
            if (e == null)
            {
                return false;
            }

            e.Name = employee.Name;
            e.UserName = employee.UserName;
            e.Password = employee.Password;
            e.JobTitle = employee.JobTitle;
            e.BirthDate = employee.BirthDate;
            e.HireDate = employee.HireDate;
            e.Address = employee.Address;

            return true;
        }
    }
}
