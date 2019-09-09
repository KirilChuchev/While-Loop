using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_1
{
	class Program
	{
		static void Main(string[] args)
		{

			using System;
			using System.Collections.Generic;
			using System.Linq;
			using System.Text;
			using System.Threading.Tasks;

namespace Moving
	{
		class Program
		{
			static void Main(string[] args)
			{
				int width = int.Parse(Console.ReadLine());
				int lenght = int.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());

				int freeSpace = width * lenght * height;

				while (true)
				{
					string command = Console.ReadLine();

					if (command == "Done")
					{
						Console.WriteLine($"No more free space! You need {freeSpace} Cubic meters more.");
						break;
					}

					int boxes = int.Parse(command);
					freeSpace -= boxes;

					if (freeSpace <= 0)
					{
						Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
						break;
					}


				}



				while (true)
				{

				}
			}
		}
	}

}
	}
}
