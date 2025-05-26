using EmployeesApp.Application;
using EmployeesApp.Domain;
using EmployeesApp.Infrastructure;

namespace EmployeesApp.Terminal;

public class Terminal
{    
    public static void Main()
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        IEmployeeService employeeService = new EmployeeService(employeeRepository);

        foreach (Employee employee in employeeService.GetAll())
        {
            Console.WriteLine(employee.Name);
        }

        Console.WriteLine("\nKlicka på valfri tangent för att fortsätta.");
        Console.ReadKey();
        

        bool searchingForId = true;
        while (searchingForId)
        {
            try
            {
                Console.WriteLine("Sök efter ID: ");
                string? input = Console.ReadLine();     

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Inmatningen är tom/null.");
                    continue;
                }
                int id = 0;
                bool isInteger = int.TryParse(input, out id);

                if (!isInteger)
                {
                    Console.WriteLine("Inmatningen måste vara ett tal.");
                    continue;
                }

                Employee employee = employeeService.GetById(id);
                               
                Console.WriteLine(employee.Name);
                Console.WriteLine("\nKlicka på valfri tangent för att fortsätta.");
                Console.ReadKey();

            }

            catch (ArgumentException err)
            {
                Console.WriteLine("Error: " + err);
            }
        }
        
    }
}
