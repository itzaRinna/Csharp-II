using System;

namespace _23rdProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mảng 3 chiều

            // int[,,] a = //new int[2, 3, 4]
            // {
            //     {
            //         {1,2,3,4},
            //         {3,4,3,4},
            //         {1,2,3,4}
            //     },
            //     {            
            //         {1,2,3,4},
            //         {3,4,3,4},
            //         {1,2,3,4}
            //     }
            // };
            // for (int i = 0; i < a.GetLength(0); i++)
            // {
            //     for (int j = 0; j < a.GetLength(1); j++)
            //     {
            //         for (int k = 0; k < a.GetLength(2); k++)
            //         {
            //             Console.WriteLine(a[i,j,k]);
            //         }
            //     }  
            // }

            #endregion

            #region Mảng jagged

            // int[][] a = new int[3][];
            // a[0] = new int[5];
            // a[1] = new int[9];

            // int[][] a =
            // {
            //     new int[] { 1, 2, 3 },
            //     new int[] { 4, 5, 6 }
            // };
            //
            // for (int i = 0; i < a.Length; i++)
            // {
            //     for (int j = 0; j < a[i].Length; j++)
            //     {
            //         Console.WriteLine(a[i][j]);
            //     }
            // }

            #endregion

            #region Lớp Array

            /*
             * Khai báo và khởi tạo mảng 1 chiều tên IntArray có 4 phần tử chưa được sắp xếp
             */

            int[] IntArray = { 5, 2, 1, 3 };


            /*
             * Thực hiện câu lệnh sắp xếp mảng
             * Ở đây mặc định là sẽ sắp xếp tăng dần.
             * Nếu bạn muốn sắp xếp giảm dần có thể tận dụng phương thức đảo ngược các giá trị mảng để được mảng giảm dần
             */

            Array.Sort(IntArray);
            Console.WriteLine(" Mang da sap xep tang dan: ");

            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("\t" + IntArray[i]);
            }
            Console.WriteLine();

            /* Đảo ngược các phần tử của mảng để được 1 mảng giảm dần */
            Array.Reverse(IntArray);
            Console.WriteLine(" Mang da sap xep giam dan: ");

            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("\t" + IntArray[i]);
            }

            Console.WriteLine();
            
            Console.WriteLine(" Vi tri cua so 1 trong mang la: "+ Array.IndexOf(IntArray, 1));

            #endregion
        }
    }
}