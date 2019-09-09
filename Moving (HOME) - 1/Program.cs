using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = int.Parse(Console.ReadLine());
			int lendth = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());

			string command = "";
			

			int maxVolume = width * lendth * height;
			int baggage = 0;
			int baggageSum = 0;


			while (true)
			{
				command = Console.ReadLine();
				command = command.ToLower();

				if (command == "done")
				{
					Console.WriteLine($"{ maxVolume - baggageSum} Cubic meters left.");
					break;
				}

				baggage = int.Parse(command);

				baggageSum += baggage;

				if (baggageSum > maxVolume)
				{
					Console.WriteLine($"No more free space! You need {baggageSum - maxVolume} Cubic meters more.");
					break;
				}

				

				

			}

			

		}
	}
}
