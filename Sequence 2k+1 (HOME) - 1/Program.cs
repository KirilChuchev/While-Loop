using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2k_1__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int ourNumber = int.Parse(Console.ReadLine());

			int result = 1;
			
			

			while (result <= ourNumber)
			{
				Console.WriteLine(result);
				result = (result * 2) + 1;

			}

			
		}
	}
}
