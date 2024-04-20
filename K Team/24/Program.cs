using System;

namespace _24thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cấu trúc

            // foreach (<kiểu dữ liệu> <tên biến tạm> in <tên mảng hoặc tập hợp>)
            // {
            //     // Code xử lí
            // }

            #endregion

            #region Sử dụng foreach để duyệt mảng 1 chiều

            // /*
            //  * Khai báo mảng 1 chiều IntArray và khởi tạo giá trị.
            //  * Các bạn có thể xem lại cú pháp này ở bài Mảng 1 chiều trong C#
            //  * Khai báo 1 biến Sum để chứa giá trị tổng các phần tử trong mảng IntArray.
            //  */
            // int[] IntArray = { 1, 5, 2, 4, 6 };
            // int Sum = 0;
            //
            // /*
            //  * Sử dụng foreach để duyệt mảng và in giá trị của các phần tử trong mảng.
            //  * Đồng thời tận dụng vòng lặp để tính tổng các phần tử trong mảng.
            //  */
            // foreach (int item in IntArray)
            // {
            //     Console.Write("\t" + item);
            //     Sum += item;
            // }
            //
            // Console.WriteLine("\n Sum = " + Sum);
            
            #endregion

            #region Sử dụng foreach duyệt mảng jagged

            /*
             * Khai báo 1 mảng jagged tên là JaggedArray và khởi tạo giá trị.
             * Các bạn có thể xem lại cú pháp khai báo này ở bài Mảng nhiều chiều trong C#.
             */
            int[][] JaggedArray = 
            { 
                new int[] { 1, 2, 3 },
                new int[] { 5, 2, 4, 1, 6},
                new int[] { 7, 3, 4, 2, 1, 5, 9, 8}
            };

            /*
             * Tương tự như dùng for, ta cũng dùng 2 vòng foreach lồng vào nhau để duyệt mảng.
             */
            foreach (int[] Element in JaggedArray)
            {
                foreach (int item in Element)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}