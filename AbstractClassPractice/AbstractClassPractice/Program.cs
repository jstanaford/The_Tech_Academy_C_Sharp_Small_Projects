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

			//call SayName
			Employee employee = new Employee();
			employee.FirstName = "Sample";
			employee.LastName = "Student";

			employee.SayName();
			Console.ReadLine();


			//calling Quit()
			IQuittable quit1 = new Employee();
			quit1.Quit();
		

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

	public class Employee : Person, IQuittable
	{

	public virtual void SayName()
		{
			
		}

	public void Quit()
		{
			Console.WriteLine("Press enter to quit");
			Console.ReadLine();
		}

	}
}
