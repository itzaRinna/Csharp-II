using System;

namespace FourteenthProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cấu trúc

            // for (* Khởi tạo *; * Điều kiện lặp *; * Bước lặp *)
            // {
            //     // Khối lệnh được lặp lại
            // }

            #endregion

            #region VD1

            // int count;
            // for (count = 0; count < 10; count++)
            // {
            //     Console.WriteLine(count);
            // }

            #endregion

            #region VD2

            // int i = 0;
            // int j = 0;
            // for (i = 0; i < 10; i++, j += 3)
            // {
            //     Console.WriteLine("{0} | {1}",i, j);
            // }

            #endregion

            #region VD_Đầy đủ

            // int n = 100;
            // int j = 0;
            //
            // for (int i = 0; i * j < n; i++, j += 3, Console.WriteLine("HowKTeam.com For Loop {0}", i))
            // {
            //     Console.WriteLine("=======================================");
            //     Console.WriteLine("i: {0} | j: {1} | i * j: {2}", i, j, i * j);
            // }

            #endregion

            #region Vẽ hình chữ nhật

            int N = 5;
            int M = 20;

            char drawChar = '*';
            char insideChar = '-';


            // Vẽ từ trên xuống
            for (int i = 0; i < N; i++)
            {                               
                // Vẽ từ trái sang
                for (int j = 0; j < M; j++)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                     */

                    if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                }
                //mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
            
        }
    }
}