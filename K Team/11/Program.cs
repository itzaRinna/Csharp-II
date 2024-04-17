using System;

namespace EleventhProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Đặc điểm của kiểu dynamic
            
            // // Khai báo biến StringValue kiểu dynamic và khởi tạo giá trị là một chuỗi kiểu string
            // dynamic StringValue = "HowKteam";
            //
            // /*
            //  * Chúng ta biết rằng kiểu chuỗi không hỗ trợ toán tử ++
            //  * Nhưng câu lệnh StringValue++ vẫn không báo lỗi là do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định kiểu dữ liệu cho biến StringValue
            //  * Khi chạy chương trình thì lúc này C# mới phát hiện biến StringValue là kiểu string và không thể thực hiện toán tử ++ lúc đó sẽ xuất hiện lỗi
            //  */
            // StringValue++;
            
            #endregion

            #region Chương trình sử dụng dynamic

            // Khai báo 2 biến Name và Mission kiểu string và khởi tạo giá trị.
            string Name = "HowKteam ";
            string Mission = "Free Education";

            /*
             * Thực hiện gán 1 biến kiểu string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
             * Sau phép gán này thì biến DynamicValue chứa giá trị là "Free Education" nhưng kiểu dữ liệu của nó vẫn chưa được xác định.
             */
            dynamic DynamicName = Name;

            // Thực hiện cộng chuỗi và in ra màn hình bình thường
            Console.WriteLine("Mission of " + DynamicName + " is " + Mission);
            
            #endregion

            Console.ReadKey();
        }
    }
}