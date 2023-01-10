using System;
using Capgemini.EMS.Businesslayer;
using Capgemini.EMS.Entities;
using Capgemini.EMS.Exceptions;
//Hello bro


namespace Capgemini.EMS.PL
{
    class EMSPresentationLayer
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----> 1 Add employee , 2 Employee List , 3 Update employee , 4 Delete employee , 5 Exit");
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int empId))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                switch (empId)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        EmployeeList();
                            break;
                    case 3:
                        UpdateEmployee();
                            break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;


                }


            }

        }

        private static void AddEmployee()
        {
            Employee newEmployee = new Employee();
            
            string input;
            int empId;
            do
            {
                Console.Write("Enter employee Id: ");
                input = Console.ReadLine();
                
            }
            while (!int.TryParse(input, out empId));

            newEmployee.Id = empId;

            do
            {
                Console.Write("Enter employee Name : ");
                input = Console.ReadLine();
               
            }
            while (string.IsNullOrEmpty(input));
            newEmployee.Name = input;

            DateTime dateofjoining;

            do
            {
                Console.Write("Enter Date of joining: ");
                input = Console.ReadLine();

            } while (!DateTime.TryParse(input, out dateofjoining));
            newEmployee.Dateofjoining = dateofjoining;

            try
            {
                bool isAdded = EmployeeBL.Add(newEmployee);
                if (isAdded)
                {
                    Console.WriteLine("Employee added sucessfully!");
                }
                else
                {
                    Console.WriteLine("Employee adding failed!");
                }
            }
            catch (EMSExeptions ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private static void EmployeeList()
        {
            var list = EmployeeBL.GetList();
            Console.WriteLine("Employee List");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
        private static void  UpdateEmployee()
        {
            string input;
            int empId;
            do
            {
                Console.Write("Enter employee id: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out empId));
            var existingEmployee = EmployeeBL.GetById(empId);
            if (existingEmployee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            Employee newemp = new Employee();
            newemp.Id = empId;
            do
            {
                Console.Write("Enter employee name: ");
                input = Console.ReadLine();

            } while (string.IsNullOrEmpty(input));
            newemp.Name = input;
            DateTime dateofjoining;
            do
            {
                Console.Write("Enter date of joining ");
                input = Console.ReadLine();
            } while (!DateTime.TryParse(input, out dateofjoining));
            newemp.Dateofjoining = dateofjoining;

            var isUpdated = EmployeeBL.Update(newemp);
            if (isUpdated)
            {
                Console.WriteLine("Employee updated sucessfully");
            }
        }


        //Employee deletion
        private static void DeleteEmployee()
        {
            Employee newEmp = new Employee();
            string input;
            int empId;
            DateTime dateofjoining;
            do
            {
                Console.Write("Enter employee id: ");
                input = Console.ReadLine();

                
            }
            while (!int.TryParse(input, out empId));
            newEmp.Id = empId;

            var existingEmployee = EmployeeBL.GetById(empId);
            if (existingEmployee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            var isDeleted = EmployeeBL.Delete(newEmp);
            if (isDeleted)
            {
                Console.WriteLine("Deleted sucessfully!");
            }
            else
            {
                Console.WriteLine("Deletion failed!");
            }
        }

    }
}
