using EmployeesApp.Domain;

namespace EmployeesApp.Application
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
    {
       

        public void Add(Employee employee)
        {
         
            employeeRepository.Add(employee);
        }

    
        public Employee[] GetAll() => employeeRepository.GetAll();


        public Employee GetById(int id) => employeeRepository.GetById(id);

        public bool CheckIsVIP(Employee employee) => employeeRepository.CheckIsVIP(employee);

    }
}