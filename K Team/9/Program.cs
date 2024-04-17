using System;

namespace Ninth
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch dạng thiếu
            
            // int k = 10;
            //
            // switch (k)
            // {
            //     case 3:
            //         Console.WriteLine("HowKteam");
            //         break; // Vì case này có lệnh thực hiện nên phải có lệnh break 
            //     case 9:
            //         Console.WriteLine("Kteam");
            //         break;
            //     case 10:
            //         Console.WriteLine("Free Education");
            //         break;
            // }
            
            #endregion

			#region Switch dạng đủ
            
            // int k = 8;
            //
            // switch (k)
            // {
            //     case 3:
            //         Console.WriteLine("HowKteam");
            //         break;
            //     case 9:
            //         Console.WriteLine("Kteam");
            //         break;
            //     case 10:
            //         Console.WriteLine("Free Education");
            //         break;
            //     default: // Nếu không thỏa các trường hợp trên sẽ thực hiện lệnh sau đây
            //         Console.WriteLine("Connecting to HowKteam. . .");
            //         break;
            // }
            
			#endregion
            
            int Year; // Biến chứa giá trị năm cần tính.
            string Can = "", Chi = ""; // Biến chứa kết quả.

            Console.Write(" Moi ban nhap mot nam bat ky: ");
            Year = Int32.Parse(Console.ReadLine()); // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            
            switch (Year % 10) // Tìm Can như thuật toán đã trình bày.
            {
                case 0: // Mỗi case này tương ứng một kết quả cần tra cứu trong bảng tra cứu Can
                    Can = "Canh"; // Giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Can = "Tan";
                    break;
                case 2:
                    Can = "Nham";
                    break;
                case 3:
                    Can = "Quy";
                    break;
                case 4:
                    Can = "Giap";
                    break;
                case 5:
                    Can = "At";
                    break;
                case 6:
                    Can = "Binh";
                    break;
                case 7:
                    Can = "Dinh";
                    break;
                case 8:
                    Can = "Mau";
                    break;
                case 9:
                    Can = "Ky";
                    break;
            }

            switch (Year % 12) // Tìm Chi như thuật toán đã trình bày
            {
                case 0: // Mỗi case này tương ứng một kết quả cần tra cứu trong bảng tra cứu Chi
                    Chi = "Than"; // Giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Chi = "Dau";
                    break;
                case 2:
                    Chi = "Tuat";
                    break;
                case 3:
                    Chi = "Hoi";
                    break;
                case 4:
                    Chi = "Ty";
                    break;
                case 5:
                    Chi = "Suu";
                    break;
                case 6:
                    Chi = "Dan";
                    break;
                case 7:
                    Chi = "Meo";
                    break;
                case 8:
                    Chi = "Thin";
                    break;
                case 9:
                    Chi = "Ti";
                    break;
                case 10:
                    Chi = "Ngo";
                    break;
                case 11:
                    Chi = "Mui";
                    break;
            }

            Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can, Chi); // Nối Can và Chi lại để được năm âm lịch

            
            Console.ReadKey();
        }
    }
}