using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
	class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<Employee> developers = new Employee[]
			{
				new Employee { Id = 1, Name= "Scott" },
				new Employee { Id = 2, Name= "Chrissy" },
				new Employee { Id = 4, Name= "Adam" }
			};
			// Named method approach
			IEnumerable<Employee> sales = new List<Employee>()
			{
				new Employee { Id = 3, Name = "Alex" }
			};
			foreach (var employee in developers.Where(e => e.Name.Length == 5)
											   .OrderBy(e => e.Name))
			{
				Console.WriteLine(employee.Name);
			}
			/* Lamba Expression Approach
			foreach (var employee in developers.Where(e => e.Name.StartsWith("S")))
			{
				Console.WriteLine(employee.Name);
			}*/

			Lambdas();
		}

		private static bool NameStartsWithS(Employee employee)
		{
			return employee.Name.StartsWith("S");
		}

		private static void Lambdas()
		{
			// Last parameter is return type
			Func<int, int> square = x => x * x;
			Func<int, int, int> add = (x, y) =>
			{
				int temp = x + y;
				return temp;
			};
			// Func with void return type is an Action
			Action<int> write = x => Console.WriteLine(x);
			write(square(add(3, 5)));
		}
	}
}
