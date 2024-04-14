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

            int H, K, T;
            H = K = T = 10;
            Console.WriteLine(" H = {0}, K = {1}, T = {2}",H,K,T);

            H += K = T = 5;
            Console.WriteLine(" H = {0}, K = {1}, T = {2}",H,K,T);

            Console.ReadKey();

            #endregion
        }
    }
}