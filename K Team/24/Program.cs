﻿using System;
using System.Diagnostics;
using System.Threading;

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

            // /*
            //  * Khai báo 1 mảng jagged tên là JaggedArray và khởi tạo giá trị.
            //  * Các bạn có thể xem lại cú pháp khai báo này ở bài Mảng nhiều chiều trong C#.
            //  */
            // int[][] JaggedArray = 
            // { 
            //     new int[] { 1, 2, 3 },
            //     new int[] { 5, 2, 4, 1, 6},
            //     new int[] { 7, 3, 4, 2, 1, 5, 9, 8}
            // };

            // /*
            //  * Tương tự như dùng for, ta cũng dùng 2 vòng foreach lồng vào nhau để duyệt mảng.
            //  */
            // foreach (int[] Element in JaggedArray)
            // {
            //     foreach (int item in Element)
            //     {
            //         Console.Write(item + "  ");
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            #region Kiểm tra tốc độ của For và Foreach khi duyệt mảng 1 chiều (có khả năng truy xuất ngẫu nhiên)

            // /* Kiểm tra tốc độ của for */

            // /*
            //  * Sử dụng 1 cái đồng hồ để đo thời gian chạy của 2 vòng lặp for và foreach
            //  * Ở đây mình chỉ kiểm tra tốc độ chứ không tập trung giải thích cú pháp
            //  * Các bạn có thể tìm hiểu thêm.
            //  */
            // Stopwatch start = new Stopwatch();
            // start.Start();

            // int[] IntArray = new int[Int32.MaxValue / 100];
            // int s = 0;
            // int Length = IntArray.Length;
            // for (int i = 0; i < Length; i++)
            // {
            //     s += IntArray[i];
            // }

            // start.Stop();
            // Console.WriteLine(" Thoi gian chay cua for: {0} giay {1} mili giay", start.Elapsed.Seconds, start.Elapsed.Milliseconds);

            // /* Kiểm tra tốc độ của foreach */
            // Stopwatch start2 = new Stopwatch();
            // start2.Start();

            // int[] IntArray2 = new int[Int32.MaxValue / 100];
            // int s2 = 0;

            // foreach (int item in IntArray2)
            // {
            //     s2 += item;
            // }

            // start2.Stop();
            // Console.WriteLine(" Thoi gian chay cua foreach: {0} giay {1} mili giay", start2.Elapsed.Seconds, start2.Elapsed.Milliseconds);


            #endregion

            #region Kiểm tra tốc độ của For và Foreach khi duyệt 1 danh sách

            /*
             * Khai báo 1 LinkedList chưa các số nguyên int và khởi tạo giá trị cho nó.
             */
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.AddLast(i);
            }

            /* Kiểm tra tốc độ của for */
            Stopwatch st = new Stopwatch();
            int s1 = 0, length = list.Count;
            st.Start();
            for (int i = 0; i < length; i++)
            {
                /*
                 * Vì LinkedList không thể truy xuất thông qua chỉ số phần tử
                 * nên mình phải sử dụng 1 phương thức hỗ trợ làm điều này.
                 * Và đây chính là sự hạn chế của for đối với các cấu trúc dữ liệu tương tự như danh sách liên kết này.
                 */
                s1 += list.ElementAt(i);
            }
            st.Stop();

            /* Kiểm tra tốc độ của foreach */
            Stopwatch st2 = new Stopwatch();
            int s2 = 0;
            st2.Start();
            foreach (int item in list)
            {
                /*
                 * Vì foreach không quan tâm đến chỉ số phần tử nên code viết rất ngắn gọn
                 */
                s2 += item;
            }
            st2.Stop();

            /* In ra giá trị tính tổng giá trị các phần tử khi duyệt bằng for và foreach để chắc chắn rằng cả 2 đều chạy đúng */
            Console.WriteLine(" s1 = {0}   s2 = {1}", s1, s2);
            Console.WriteLine(" Thoi gian chay cua for = {0} giay {1} mili giay", st.Elapsed.Seconds, st.Elapsed.Milliseconds);
            Console.WriteLine(" Thoi gian chay cua foreach = {0} giay {1} mini giay", st2.Elapsed.Seconds, st2.Elapsed.Milliseconds);

            #endregion
        }
    }
}