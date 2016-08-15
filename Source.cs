using System;

namespace Conway
{
	class Board
	{
		public void setDims()
		{
			Console.WriteLine("How big do you want this grid to be?");
			Console.WriteLine("Width: ");
			Console.WriteLine(" ");
			Width = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Height: ");
			Console.WriteLine(" ");
			Height = Convert.ToInt32(Console.ReadLine());
		}

		public void initBoard()
		{
			currentLife = new char [Height,Width];
			futureLife = new char [Height,Width];

			for(int i = 0; i < Height; ++i)
			{
				for(int k = 0; k < Width; ++k)
				{
					currentLife[i,k] = '0';
					futureLife[i,k] = '0';

				}

			}
		}

		public void setLife()
		{
			Console.WriteLine("Life will spawn according to the coordinates that you give.");
			Console.WriteLine("Give as many coordinates as you like.");

			bool cont = true;

			int coordCount = 0;
			int maxCoordinates = Height * Width;
			int convertX, convertY;

			string x, y;

			while(cont == true)
			{
				Console.Clear();

				Console.WriteLine("Enter a coordinate when prompted or enter the key '!' to stop adding coordinates");

				Console.WriteLine("X Coordinate:");
				x = Console.ReadLine();
				Console.WriteLine(" ");

				if(x.Equals("!") == false)
				{
					Console.WriteLine("Y Coordinate:");
					y = Console.ReadLine();
					Console.WriteLine(" ");

					convertX = Convert.ToInt32(x);
					convertY = Convert.ToInt32(y);

					currentLife[convertX, convertY] = 'X';

					Console.WriteLine("Life at: ( " + convertX + " , " + convertY + " )" + " Has been added.");
					displayBoard();

					System.Threading.Thread.Sleep(3000);

					++coordCount;
				}

				if(x.Equals("!") == true)
					cont = false;

				if(coordCount == maxCoordinates)
					cont = false;
			}
		}

		public void displayBoard()
		{
			for(int i = 0; i < Height; ++i)
			{
				for(int k = 0; k < Width; ++k)
				{
					Console.Write(currentLife[i,k]);

					if(k == Width - 1)
						Console.WriteLine(" ");
				}
			}
		}

		private static int Height;
		private static int Width;

		private char[,] currentLife;
		private char[,] futureLife;
	}

	class Life
	{
		static void Main()
		{

			Board obj = new Board();

			obj.setDims();
			obj.initBoard();
			obj.setLife();

			Console.WriteLine(" ");
			obj.displayBoard();
		}
	}
}