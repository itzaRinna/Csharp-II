﻿using System;

namespace EighthProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Câu điều kiện dạng thiếu
			
			// string K = "HowKteam";
			//
			// if(K=="Kteam")
			// 	Console.WriteLine("Free Education");

			#endregion

			#region Câu điều kiện dạng đủ

			// string K = "10-09";
			//
			// if (K == "HowKteam")
			// {
			// 	Console.WriteLine("HowKTeam.com");
			// 	Console.WriteLine("Free Education");
			// }
			// else if (K == "Kteam")
			// {
			// 	Console.WriteLine("Share to be better!");
			// }
			// else
			// {
			// 	if (K == "10-09")
			// 	{
			// 		Console.WriteLine("Public website howkteam.com");
			// 	}
			// 	else
			// 	{
			// 		Console.WriteLine("Connecting HowKteam...");
			// 	}
			// }

			#endregion

			string strA, strB;
			int A, B;
			double Nghiem;

			Console.WriteLine("         ***************************************************");
			Console.WriteLine("         *                                        			        *");
			Console.WriteLine("         *    Chuong trinh giai phuong trinh Ax + B = 0 *");
			Console.WriteLine("         *                                                 		        *");
			Console.WriteLine("         ***************************************************");

			Console.Write(" Moi nhap so A: ");
			strA = Console.ReadLine();
			Console.Write(" Moi nhap so B: ");
			strB = Console.ReadLine();

			if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false) // kiểm tra người dùng có thực sự nhập số nguyên vào hay không. Nếu ép kiểu thành công sẽ trả về true, ngược lại trả về false
			{
				Console.WriteLine(" Du lieu nhap sai !"); 
				return; // Lệnh này tạm hiểu là dừng và thoát chương trình mà không thực hiện những câu lệnh sau nó nữa. Sẽ được tìm hiểu chi tiết trong bài 16 Hàm
			}
			else
			{
				Console.WriteLine("\n Phuong trinh cua ban vua nhap la: {0}x + {1} = 0", A, B);

				if (A == 0)
				{
					Console.WriteLine("\n Phuong trinh co vo so nghiem !");
				}
				else if (B == 0)
				{
					Console.WriteLine("\n Phuong trinh co nghiem x = 0");
				}
				else
				{
					Nghiem = (double)-B / A; // Ép kiểu để cho ra kết quả chính xác
					Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Nghiem);
				}
			}
			
			Console.ReadKey();
        }
    }
}