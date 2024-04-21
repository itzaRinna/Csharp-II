using System;

namespace _27thProgram
{
	class Program
	{
		enum Color
		{
		RED = 2,
		BLUE = 4,
		YELLOW = 6,
		}
		static void Main(string[] args)
		{
			#region Khai báo và ví dụ

			// enum Color
			// {
			// RED = 2,
			// BLUE = 4,
			// YELLOW = 6,
			// }
			Color myVar1 = Color.RED; 
			Color myVar2 = Color.BLUE; 
			Color myVar3 = Color.YELLOW; 

			Console.WriteLine((int)myVar1);
			Console.WriteLine((int)myVar2);
			Console.WriteLine((int)myVar3);


			#endregion
		}
	}
}