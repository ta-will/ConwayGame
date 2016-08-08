using System;

namespace Conway
{
	class Board
	{
		public void setDims(int x, int y)
		{
			Height = x;
			Width = y;
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

			obj.setDims(9,16);
			obj.initBoard();
			obj.displayBoard();
		}
	}
}