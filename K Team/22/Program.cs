using System;

namespace _22thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Khai báo, khởi tạo và cấp phát vùng nhớ cho mảng 2 chiều

            /*
             * Khai báo mảng 2 chiều kiểu string và có tên là Kteam.
             * Sau đó thực hiện cấp phát vùng nhớ với số dòng là 2 và số cột là 3
             */

            // string[,] Array = new string[2, 3];
            // string[,] Kteam = new string[,]
            //                     {
            //                         { "HowKteam", "Free Education" },
            //                         { "HowKteam.com", "Share to be better" }
            //                     };
            // int[,] IntArray = 
            //         {
            //             {1,2},
            //             {3,4},
            //             {5,6},
            //         };
            #endregion

            #region Sử dụng mảng 2 chiều

            // Khai báo, cấp phát và khởi tạo mảng 2 chiều kiểu string và tên là Kteam
            // int[,] Kteam = 
            //         { 
            //             {1, 2}, 
            //             {3, 4}, 
            //             {5, 6} 
            //         };
            /* 
            * Vì chỉ số phần tử được đánh số từ 0 nên muốn truy xuất đến phần tử dòng 1 cột 2 của mảng 
            thì chỉ số dòng là 0 và chỉ số cột là 1
            */	
            // Console.WriteLine(Kteam[0, 1]); // => 2

            // int[,] IntArray = new int [9, 10];
            /*
             * Sử dụng 2 vòng for lồng vào nhau để duyệt mảng 2 chiều
             * Vòng lặp ngoài là vòng lặp duyệt mỗi dòng của của mảng 2 chiều
             * Với mỗi dòng thì vòng lặp trong là vòng lặp duyệt các phần tử trên dòng đó (duyệt từng cột trên dòng hiện tại)
             */
            // for (int i = 0; i < 9; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         /* 
            //          * Với cách duyệt này thì IntArray[i, j] sẽ là phần tử hiện tại mình đang xét
            //          * Code xử lý sẽ viết ở đây
            //          */
            //     }
            // }
            /*
             * Duyệt mảng 2 chiều theo cột
             * Các bạn để ý sự thay đổi trong 2 vòng lặp
             */
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 9; j++)
            //     {
            //         /* 
            //          * Lưu ý là các phần tử được truy xuất là IntArray[j, i] thay vì IntArray[i, j]
            //          * Code xử lý 
            //          */
            //     }
            // }
            /*
             * Như đã trình bày ở phần trước thì:
             * GetLength(0) sẽ trả về số dòng của mảng 2 chiều
             * GetLength(1) sẽ trả về số cột của mảng 2 chiều
             */
            // for (int i = 0; i < IntArray.GetLength(0); i++)
            // {
            //     for (int j = 0; j < IntArray.GetLength(1); j++)
            //     {
            //         // Code xử lý
            //     }
            // }

            #endregion

            #region VD chương trình sử dụng mảng 2 chiều

            Console.Write(" Moi ban nhap so dong cua mang: ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write(" Moi ban nhap so cot cua mang: ");
            int Columns = int.Parse(Console.ReadLine());

            // Tạo 1 mảng 2 chiều với số dòng và số cột đã nhập
            int[,] IntArray = new int[Rows, Columns];
            /* 
             * Duyệt mảng để nhập giá trị cho các phần tử
             * Ở đây mình muốn minh họa cách sử dụng mảng nên mình bỏ qua các bước kiểm tra dữ liệu mà ép kiểu trực tiếp
             * Điều này có thể gây lỗi khi nhập sai nên các bạn hãy cải tiến chương trình này cho đầy đủ nhé!
             */
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntArray[{0}, {1}] = ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            /*
             * In mảng 2 chiều đã nhập ra màn hình
             * Để tính tổng các giá trị trong mảng ta chỉ cần duyệt qua các phần tử và cộng chúng lại với nhau
             * Tận dụng lúc duyệt mảng để in giá trị ta sẽ thực hiện tính tổng luôn để tránh phải duyệt lại mảng thêm lần nữa.
             */
            int Sum = 0;

            Console.WriteLine("\n Mang ban vua nhap la: ");
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(IntArray[i, j] + " ");
                    Sum = Sum + IntArray[i, j];
                }
                // Sau khi in xong mỗi dòng ta thực hiện xuống dòng rồi mới in tiếp
                Console.WriteLine();
            }
            Console.WriteLine(" Tong cac gia tri trong mang: " + Sum);


            #endregion
        }
    }
}