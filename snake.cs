using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	/// <summary>
	/// Firure.
	/// </summary>
	public class Firure{

		protected List<Point> plist;

		public void Drow(){

			foreach(Point p in plist){

				p.Draw ();

			}

		} 

	}


	/// <summary>
	/// Class VerticallLine.
	/// </summary>
	public class VerticalLine : Firure
	{
 
		public VerticalLine(int yLeft, int yRight, int x, char sym){    

			plist = new List<Point>();
			for(int y = yLeft; y<=yRight; y++){

				Point p = new Point (x, y, sym);
				plist.Add (p);
			}

		}
 
	}

	/// <summary>
	/// Class HorizontalLine
	/// </summary>
	public class HorizontalLine : Firure
	{
		 
		public HorizontalLine(int xLeft, int xRight, int y, char sym){
		
			plist = new List<Point>();
			for(int x = xLeft; x<=xRight; x++){

				Point p = new Point (x, y, sym);
				plist.Add (p);
			}
			
		}
 
	}


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

			//Console.SetBufferSize (80, 25);

			HorizontalLine line_top = new HorizontalLine (0, 78, 0, '+');
			line_top.Drow ();
			HorizontalLine line_bottom = new HorizontalLine (0, 78, 24, '+');
			line_bottom.Drow ();

			VerticalLine line_left = new VerticalLine (0, 24, 0, '+');
			line_left.Drow ();
			VerticalLine line_right = new VerticalLine (0, 24, 78, '+');
			line_right.Drow ();

			Point p = new Point (4,5,'*');
			p.Draw ();

			Console.ReadLine ();


		}
		 
}
}