using EmployeesApp.Domain;

namespace EmployeesApp.Application
{
    public interface IEmployeeService
    {
        void Add(Employee employee);

        Employee[] GetAll();

        Employee? GetById(int id);

        public bool CheckIsVIP(Employee employee);
    }
}
