using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPractice
{
	class Program
	{
		static void Main(string[] args)
		{

			Number price1 = new Number();
			price1.Amount = 105.50m;


			Console.WriteLine(price1.Amount);
			Console.ReadLine();
		}
	}
	
	public struct Number
	{
		public decimal Amount;
	}
}
