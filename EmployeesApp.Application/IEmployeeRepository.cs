using EmployeesApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Application
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        Employee[] GetAll();

        Employee? GetById(int id);

        public bool CheckIsVIP(Employee employee);
    }
}
