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
			//Console.WriteLine("Press enter to see if employees Sample Student and Jacob Stanaford share the same idea number.\nAnswer will be true or false");
			//Console.ReadLine();
			////call SayName
			//Employee employee = new Employee();
			//employee.FirstName = "Sample";
			//employee.LastName = "Student";
			//employee.ID = 1;


			//Employee employee2 = new Employee();
			//employee2.FirstName = "Jacob";
			//employee2.LastName = "Stanaford";
			//employee2.ID = 2;

			//bool Answer = employee == employee2;
			//Console.WriteLine(Answer);

			////employee.SayName();
			//Console.ReadLine();


			////calling Quit()
			//IQuittable quit1 = new Employee();
			//quit1.Quit();


			//Generic property calls below

			Employee<string> list1 = new Employee<string>();
			list1.Things = new List<string>() { "These", "Are", "Words", };

			
			Employee<int> list2 = new Employee<int>();
			list2.Things = new List<int>() { 1, 0, 1, 1 };


			
			
		
			Console.ReadLine();
			
			

		}
	}


	public abstract class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public virtual void SayName()
		{
			
		}


	}

	public class Employee<T> : Person, IQuittable
	{
		public int ID { get; set; }
		public List<T> Things { get; set; }


		public override void SayName()
		{
			string fullName = FirstName + " " + LastName;
			Console.WriteLine("Name: " + fullName);
		}

		public void Quit()
		{
			Console.WriteLine("Press enter to quit");
			Console.ReadLine();
		}
		 
		//public static bool operator== (Employee employee1, Employee employee2)
		//{
		//	if (employee1.ID == employee2.ID)
		//	{
		//		return true;
		//	}
		//	else
		//	{
		//		return false;
		//	}
		//}
		
		//public static bool operator!= (Employee employee1, Employee employee2)
		//{
		//	if (employee1.ID != employee2.ID)
		//	{
		//		return true;
		//	}
		//	else
		//	{
		//		return false;
		//	}
		//}

	}
}
