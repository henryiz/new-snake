using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

	/// <summary>
	/// Class VerticallLine.
	/// </summary>
	public class VerticalLine
	{
		List<Point> plist;
		public VerticalLine(int yLeft, int yRight, int x, char sym){    

			plist = new List<Point>();
			for(int y = yLeft; y<=yRight; y++){

				Point p = new Point (x, y, sym);
				plist.Add (p);
			}

		}
		public void Drow(){

			foreach(Point p in plist){

				p.Draw ();

			}

		}
	}

	/// <summary>
	/// Class HorizontalLine
	/// </summary>
	public class HorizontalLine
	{
		List<Point> plist;
		public HorizontalLine(int xLeft, int xRight, int y, char sym){
		
			plist = new List<Point>();
			for(int x = xLeft; x<=xRight; x++){

				Point p = new Point (x, y, sym);
				plist.Add (p);
			}
			
		}
		public void Drow(){
		
			foreach(Point p in plist){

				p.Draw ();

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

			HorizontalLine line = new HorizontalLine (5, 10, 25, '+');
			line.Drow ();
		 
			VerticalLine line2 = new VerticalLine (5, 10, 0, '+');
			line2.Drow ();


			Console.ReadLine ();


		}
		 
}
}