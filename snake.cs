using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	/// <summary>
	/// Class Point
	/// </summary>
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public void Draw(){

			Console.SetCursorPosition (x, y);
			Console.Write (sym);
		}
		 
		public Point(){
			Console.WriteLine ("Create a new dot");
		}
		public Point(int _x, int _y, char _sym){
			x = _x;
			y = _y;
			sym = _sym;
		}

	}

	/// <summary>
	/// Class Program
	/// </summary>

	class Program
	{
		static void Main()
		{
			Point prop = new Point(1, 3, '*');
 
			prop.Draw ();

			Point prop2 = new Point(4, 5, '#');
 
			prop2.Draw ();

			Console.ReadLine ();


		}

}
}