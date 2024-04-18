using System;

namespace SixteenthProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cấu trúc

            // do
            // {
            //     
            // } while (*Điều kiện lặp*);

            #endregion

            #region VD1

            // int countLoop = 0;
            // int countLoopTime = 0;
            // int valueNum = 10;
            // int loopTime = 5;
            //
            //
            // // Vẽ từ trên xuống LoopTime lần
            // do
            // {
            //
            //     // reset lại biến countLoop về 0 để viết lại từ đầu
            //     countLoop = 0;
            //
            //
            //     // vẽ từ trái qua valueNum lần
            //     while (countLoop < valueNum)
            //     {
            //
            //         // in ra giá trị của countLoop trong 8 vị trí
            //         Console.Write("{0,8}", countLoop);
            //
            //
            //         // tăng giá trị của biến countLoop lên một đơn vị
            //         countLoop++;
            //     }
            //
            //
            //     // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
            //     Console.WriteLine();
            //
            //
            //     // tăng giá trị countLoopTime lên một đơn vị
            //     countLoopTime++;
            //
            // } while (countLoopTime < loopTime) ;

            #endregion

            #region VD2

            int countLoop = 0;
            int countLoopTime = 0;
            int valueNum = 10;
            int loopTime = 5;
            int minRandomValue = 0;
            int maxRandomValue = 100;

            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Vẽ từ trên xuống LoopTime lần
            do
            {
                // reset lại biến countLoop về 0 để viết lại từ đầu
                countLoop = 0;

                // vẽ từ trái qua valueNum lần
                do
                {
                    // giá trị sinh ngẫu nhiên trong khoảng [minRandomValue . . maxRandomValue - 1]
                    int showValue = rand.Next(minRandomValue, maxRandomValue);

                    // in ra giá trị của showValue trong 8 vị trí
                    Console.Write("{0,8}", showValue);

                    // tăng giá trị của biến countLoop lên một đơn vị
                    countLoop++;
                } while (countLoop < valueNum);


                // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
                Console.WriteLine();

                // tăng giá trị countLoopTime lên một đơn vị
                countLoopTime++;
            } while (countLoopTime < loopTime);

            #endregion

            Console.ReadKey();
        }
    }
}