using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
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


	public abstract class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public virtual void SayName()
		{
			string fullName = FirstName + " " + LastName;
			Console.WriteLine("Name: " + fullName);
		}

	}

	public class Employee : Person
	{

	public virtual void SayName()
		{
			
		}
		

	}
}
