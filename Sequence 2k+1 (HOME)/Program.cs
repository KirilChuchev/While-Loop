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

			double result = ourNumber * 1.0;

			bool ourConditions = result >= 1 && result <= ourNumber;

			Console.WriteLine(result);

			while (ourConditions)
			{
				result = (result - 1) / 2;
				
				if (result < 1)
				{
					break;
				}

				Console.WriteLine(Math.Round(result, 1));
			}
		}
	}
}
