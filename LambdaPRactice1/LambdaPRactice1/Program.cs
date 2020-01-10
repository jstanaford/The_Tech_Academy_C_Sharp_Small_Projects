using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPRactice1
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Creating my list:
			
			List<Employee> employees = new List<Employee>();
			employees.Add(new Employee { FirstName = "Henry", LastName = "Stanaford", ID = 1 });
			employees.Add(new Employee { FirstName = "Joe", LastName = "Montana", ID = 2 });
			employees.Add(new Employee { FirstName = "Joe", LastName = "Stalin", ID = 3 });
			employees.Add(new Employee { FirstName = "Joe", LastName = "Moma", ID = 4 });
			employees.Add(new Employee { FirstName = "Harry", LastName = "Potter", ID = 5 });
			employees.Add(new Employee { FirstName = "Jacob", LastName = "Stanaford", ID = 6 });
			employees.Add(new Employee { FirstName = "Joe", LastName = "Frazier", ID = 7 });
			employees.Add(new Employee { FirstName = "Muhammad", LastName = "Ali", ID = 8 });
			employees.Add(new Employee { FirstName = "Ned", LastName = "Stark", ID = 9 });
			employees.Add(new Employee { FirstName = "Elon", LastName = "Musk", ID = 10 });

			// Step 2 the For Each Statement
			//foreach (Employee employee in employees)
			//{
			//	if (employee.FirstName == "Joe")
			//	{
			//		Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
			//	}
			//}
			//Console.ReadLine();


			// Step 3 lambda expression
			Employee employee = new Employee();
			List<Employee> newList = employee.FirstName.Select(x => x = Joe).ToList();
			Console.WriteLine(newList);



			//// Step 4 lambda express with ID greater than 5
			//Employee employee = new Employee();
			//List<Employee> newList = employee.ID.Select(x => x > 5).toList();


		}
	}
	


	public class Employee
	{
		public int ID { get; set;  }
		public string FirstName { get; set; }
		public string LastName { get; set; }

	}
}
