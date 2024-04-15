using System;

namespace FifthProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Toán tử toán học
            //
            // int i = 5, j = 5;
            //
            // Console.WriteLine(i++); // Sử dụng giá trị i để in ra rồi mới tăng i
            // Console.WriteLine(++j); // Tăng j lên rồi mới in giá trị j ra màn hình
            //
            // Console.ReadKey();

            #endregion

            #region Toán tử khởi tạo và gán

            // int H, K, T;
            // H = K = T = 10;
            // Console.WriteLine(" H = {0}, K = {1}, T = {2}",H,K,T);
            //
            // H += K = T = 5;
            // Console.WriteLine(" H = {0}, K = {1}, T = {2}",H,K,T);
            //
            // Console.ReadKey();

            #endregion

            #region VD1

            // int a, b, c;
            //
            // a = b = (c = 9) + 1; // Khởi tạo giá trị a = 10, b = 10; c = 9
            // a += b; // tương đương a = a + b
            // b = c++; // thực hiện gán giá trị c cho biến b sau đó thực hiện c = c + 1
            // --c; // thực hiện c = c - 1
            //
            // Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c);
            //
            // Console.ReadKey();
            
            #endregion

            #region VD2

            string strSoNguyen; // Biến chứa dữ liệu nhập vào bàn phím
            int SoNguyen; // Biến chứ số nhập vào từ bàn phím
            string KetQua; // Biến chứa kết quả kiểm tra số vừa nhập là chẳn hay lẻ

            strSoNguyen = Console.ReadLine(); // Đọc dữ liệu nhập vào từ bàn phím (dữ liệu này ở dạng chuỗi) sau đó gán gía trị vào biến strSoNguyen 
            SoNguyen = Int32.Parse(strSoNguyen); // Ép kiu dữ liệu vư nhập vào (dạng chuỗi) sang dạng số rồi fán giá trị vào biến SoNguyen
            KetQua = (SoNguyen % 2 == 0) ? "so chan" : "so le"; // Sử dụng toán tử 3 ngôi để kiểm tra số chẳn lẻ

            Console.WriteLine(" {0} la {1}", SoNguyen, KetQua); // In kết quả ra màn hình

            Console.ReadKey();

            #endregion
        }
    }
}