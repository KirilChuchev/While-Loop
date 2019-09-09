using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_sequence__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			string text = Console.ReadLine();
			text = text.ToLower();

			if (text == "end")
			{
				
			}
			else
			{
				int number = int.Parse(text);

				int maxNumber = number;
				int minNumber = number;


				while (text != "end")
				{
					
						number = int.Parse(text);

						//maxNumber = number;
						//minNumber = number;

						if (number > maxNumber)
						{
							maxNumber = number;
						}
						else if (number < minNumber)
						{
							minNumber = number;
						}

					text = Console.ReadLine();
					text = text.ToLower();


				}

				Console.WriteLine($"Max number: {maxNumber}");
				Console.WriteLine($"Min number: {minNumber}");
			}

				



			

			


		}
	}
}
