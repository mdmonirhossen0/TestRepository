using RepositoryPattern.DA.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DA.DA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepartmentDetails DepartmentDetails = new DepartmentDetails(new DepartmentRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Department> _listDepartment = DepartmentDetails.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("ID   |   Name    |   Address");
                        foreach (Department Department in _listDepartment)
                        {
                            Console.WriteLine(Department.DepartmentId + "  |   " + Department.DepartmentName + "  |   ");
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a customer:");
                        string id = Console.ReadLine();
                        Department aDepartment = DepartmentDetails.Get(Convert.ToInt32(id));
                        Console.WriteLine(aDepartment.DepartmentId + ". " + aDepartment.DepartmentName + " -- ");
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Department aDepartment = new Department();
                        aDepartment.DepartmentId = Convert.ToInt32(id);
                        aDepartment.DepartmentName = name;
                        bool isExecuted = DepartmentDetails.Add(aDepartment);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Department aDepartment = new Department();
                        aDepartment.DepartmentId = Convert.ToInt32(id);
                        aDepartment.DepartmentName = name;
                        bool isExecuted = DepartmentDetails.Update(aDepartment);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = DepartmentDetails.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            //Console.Read();
        }
    }
    }

