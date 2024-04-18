using System;

namespace SeventeenthProgram
{
    class Program
    {
        /// <summary>
        /// Hàm trả về giá trị số nguyên 5 thông qua tên hàm
        /// Lưu ý giá trị trả về phải cùng kiểu dữ liệu với kiểu trả về của hàm
        /// Ở đây là kiểu int
        /// </summary>
        /// <returns></returns>
        
        
        /// <summary>
        ///  hai biến firstNumber và secondNumber hiện là biến toàn cục của các hàm nằm bên trong class Program nhưng lại là biến cục bộ của class Program
        ///  Cần có từ khóa static vì các hàm sử dụng nó đều có từ khóa static
        /// </summary>
        
        /// <summary>
        /// hàm trả ra kết quả tổng của 2 số firstNumber và secondNumber
        /// </summary>
        /// <returns></returns>
        
        static void Main(string[] args)
        {
            // for (int i = 0; i < 10; i++)
            // {
            //     Demo();
            // }
            // Console.WriteLine(ReturnANumber());

            // Console.WriteLine(SumTwoNumber(5,10));
            
            // int firstNum = 0;
            // int secondNum = 3;
            //
            //
            // // in ra màn hình 10 lần tổng 2 số
            // for (int count = 0; count < 10; count++)
            // {
            //     // in ra màn hình tổng của 2 số
            //     PrintSumTwoNumber(firstNum, secondNum);
            //
            //
            //     // tính toán để tạo ra 2 số mới. Không quan trọng lắm
            //     firstNum += count;
            //     secondNum += count * 2 % 5;
            // }
            
            PrintSomeThing("K9", 22);
            PrintSomeThing("HowKteam.com", 1);
            
            Console.ReadKey();
        }

        static void Demo()
        {
            // your code

            Console.WriteLine("HowKteam.com");
        }
        
        static int ReturnANumber()
        {
            // bắt buộc phải có cấu trúc return trong thân hàm
            return 5;
        }
        
        static int SumTwoNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        
        static void PrintSumTwoNumber(int firstNumber, int secondNumber)
        {
            Console.WriteLine("{0} + {1} = {2}",firstNumber, secondNumber, SumTwoNumber(firstNumber, secondNumber));
        } 
        
        static void PrintSomeThing(string name, int age)
        {
            // in ra màn hình tên và tuổi được truyền vào
            Console.WriteLine("This is {0}, {1} years old.", name, age);
        }
        
        /*
         * [Từ khóa 1][Từ khóa 2][Từ khóa n] <Kiểu trả về> <Tên hàm> ([Parameter[]])
         * {
         *      Khối lệnh
         * }
         *
         * Từ khóa 1, từ khóa 2, từ khóa n:
         *      public
         *      static
         *      read only
         *      private...
         * Kiểu tra về:
         *      int
         *      long
         *      void
         *      (SinhVien)
         *      <Tự định nghĩa>
         * Tên hàm: tên gọi
         * Parameter: tham số truyền vào sử dụng nội bộ hàm
         */
    }
}