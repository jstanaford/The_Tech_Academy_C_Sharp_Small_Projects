using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassPractice
{
	public class Program
	{
		static void Main(string[] args)
		{

			Employee employee = new Employee();
			employee.FirstName = "Sample";
			employee.LastName = "Student";
			
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
			string FullName = FirstName + " " + LastName;
			Console.WriteLine("Name: " + FullName);
		}
		

		
	}

	class Employee : Person
	{
		public int ID { get; set; }
		


	}


}
