using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
	class Program
	{
		static void Main(string[] args)
		{
			const string userName = "Jacob";

			var newPerson = new Person("Jacobeus");
		}
	}

	public class Person
	{
		public string last;
		public string first;

		public Person(string lastName) : this(lastName, "Fred")
		{
			
		}

		public Person(string lastName, string firstName)
		{
			last = lastName;
			first = firstName;
			last = "Jakey";
			first = "Staneeeford";
		}
	}
}
