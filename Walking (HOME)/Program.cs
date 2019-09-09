using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			input = input.ToLower();

			int sumSteps = 0;
			int steps = 0;

			

			while (sumSteps < 10000)
			{


				if (input == "going home")
				{
					steps = int.Parse(Console.ReadLine());
					sumSteps += steps;
					if (sumSteps < 10000)
					{

						Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
						break;
					}
					else
					{
						// Console.WriteLine("Goal reached! Good job!");
						break;
					}
				}
				else
				{

					steps = int.Parse(input);
					sumSteps += steps;

					if (sumSteps >= 10000)
					{
						break;
					}
				}

				input = Console.ReadLine();
				input = input.ToLower();

			}


			if (sumSteps >= 10000)
			{
				Console.WriteLine("Goal reached! Good job!");
			}
			

		}
	}
}
