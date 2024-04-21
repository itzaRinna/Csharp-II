using System;
using System.Text;

namespace _25thProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Ứng dụng String vào xử lí chuỗi

			//  /*
            //  * Khai báo 1 biến kiểu chuỗi tên là FullName
            //  * Khai báo 1 biến Result chứa kết quả chuẩn hoá chuỗi.
            //  * Giá trị biến FullName được nhập từ bàn phím.
            //  */
            // string FullName;
            // string Result = "";

            // Console.Write(" Moi ban nhap ho va ten: ");
            // FullName = Console.ReadLine();

            // /* Cắt các khoảng trắng dư ở đầu và cuối chuỗi */
            // FullName = FullName.Trim();

            // /* 
            //  * Trong khi còn tìm thấy 2 khoảng trắng
            //  * thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng
            //  */
            // while (FullName.IndexOf("  ") != -1)
            // {
            //     FullName = FullName.Replace("  ", " ");
            // }
            // /*
            //  * Cắt chuỗi họ tên ra thành mảng các từ.
            //  * Sau đó duyệt mảng để chuẩn hoá từng từ một.
            //  * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến FirstChar
            //  * Cắt các chữ cái còn lại và lưu trong biến OtherChar.
            //  * Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
            //  * Cuối cùng là lưu chữ vừa chuẩn hoá vào biến Result.
            //  */
            // string[] SubName = FullName.Split(' ');

            // for (int i = 0; i < SubName.Length; i++)
            // {
            //     string FirstChar = SubName[i].Substring(0, 1);
            //     string OtherChar = SubName[i].Substring(1);
            //     SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
            //     Result += SubName[i] + " ";
            // }

            // Console.WriteLine(" Ho ten cua ban la: " + Result);

			#endregion

			#region StringBuilder

			string Value = "How";
            Value = Value + "Kteam";
            StringBuilder MutableValue = new StringBuilder("How");
 			MutableValue.Append("Kteam");

 			Console.WriteLine(MutableValue);
			#endregion
		}
	}
}