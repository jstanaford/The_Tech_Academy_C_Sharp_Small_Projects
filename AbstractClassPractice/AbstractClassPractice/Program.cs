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



		}
	}


	public abstract class Person
	{
		public string firstName { get; set; }
		public string lastName { get; set; }

		public void SayName()
		{

		}

	}

	public class Employee : Person
	{

	}
}
