﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range_1_100___HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int number = int.Parse(Console.ReadLine());

			while (number < 1 || number > 100)
			{
				Console.WriteLine("Invalid number!");
				number = int.Parse(Console.ReadLine());
			}
			Console.Write("The number is:");
			Console.WriteLine(number);

		}
	}
}
