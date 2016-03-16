using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public void Draw(){

			Console.SetCursorPosition (x, y);
			Console.Write (sym);
		}

	}

	class Program
	{
		static void Main()
		{
			Point prop = new Point();
			prop.x = 1;
			prop.y = 3;
			prop.sym = '*';
			prop.Draw ();

			Point prop2 = new Point();
			prop2.x = 8;
			prop2.y = 21;
			prop2.sym = '#';
			prop2.Draw ();

			Console.ReadLine ();


		}

}
}