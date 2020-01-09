using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassPractice
{
	class Program
	{
		static void Main(string[] args)
		{

			Employee employee = new Employee();
			employee.SayName();
			Console.ReadLine();

		}
	}

	class Person
	{
		public string FirstName { get; set; }
		public  string LastName { get; set; }

		public void SayName()
		{
			
			Console.WriteLine("Name: [full name]");
		}
		

		
	}

	class Employee : Person
	{
		public int ID { get; set; }


	}


}
