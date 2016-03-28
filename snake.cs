using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
	enum Direction{ 
		LEFT,
		RIGHT,
		UP,
		DOWN
	}


	/// <summary>
	/// Firure.
	/// </summary>
	class Firure{

		protected List<Point> plist;

		public void Drow(){

			foreach(Point p in plist){

				p.Draw ();

			}

		} 

	}


	/// <summary>
	/// Class Point
	/// </summary>
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public void Draw(){

			Console.SetCursorPosition (x, y);
			Console.Write (sym);
		}

		public Point(Point p){
			x = p.x;
			y = p.y;
			sym = p.sym;
		}
		public Point(int _x, int _y, char _sym){
			x = _x;
			y = _y;
			sym = _sym;
		}
		public void Move(int offset, Direction direction){
			if(direction == Direction.RIGHT){
				x = x + offset;
			}
			else if(direction == Direction.LEFT){
				x = x - offset;
			}
			else if(direction == Direction.UP){
				y = y - offset;
			}
			else if(direction == Direction.DOWN){
				y = y + offset;
			}
		}
		public void Clear(){
			sym = ' ';
			Draw ();
		}
	}


	/// <summary>
	/// Snake.
	/// </summary>
	class Snake : Firure
	{

		Direction direction;

		public Snake(Point tail, int lenght, Direction _direction){

			direction = _direction;

			plist = new List<Point>();
			for(int i = 0; i < lenght; i++){
				Point p = new Point (tail);
				p.Move (i, direction);
				plist.Add (p);
			}

		}

		internal void Move(){

			Point tail = plist.First ();
			plist.Remove (tail);
			Point head = GetNextPoint ();
			plist.Add (head);

			tail.Clear ();
			head.Draw ();
		}

		public Point GetNextPoint(){
			Point head = plist.Last ();
			Point nextPoint = new Point (head);
			nextPoint.Move (1, direction);
			return nextPoint;
		}

		public void HandleKey(ConsoleKey key){

			if (key == ConsoleKey.LeftArrow) 
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}

	}

	/// <summary>
	/// Class VerticallLine.
	/// </summary>
	class VerticalLine : Firure
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
	class HorizontalLine : Firure
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
			Snake snake = new Snake (p, 4, Direction.RIGHT);
			snake.Drow ();


		
			while (true) {
			
				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey ();
					snake.HandleKey (key.Key);
				}
				Thread.Sleep (100);
				snake.Move ();
			}

		 
		 
			//Console.ReadLine ();


		}
		 
}

}
