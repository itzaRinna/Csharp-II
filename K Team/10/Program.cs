using System;

namespace TenthProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object_Boxing_Unboxing

            object obj = "HowKteam.com";
            
            /*
             * boxing: chuyển từ kiểu dữ liệu sang kiểu dữ liệu tham chiếu
             */
            
            // Khởi tạo biến Value kiểu int (kiểu dữ liệu giá trị)
            int value = 109; 

            /* thực hiện boxing bằng cách:
             * Khởi tạo đối tượng ObjectValue kiểu object
             * Gán giá trị của biến Value vào ObjectValue */
            object objectValue = value;

            int newValue = (int)objectValue;

            #endregion

            #region Var

            // Lỗi vì chưa khởi tạo giá trị cho biến varInt.
            // var varInt;
            //
            // Lỗi vì không được khởi tạo giá trị null cho biến varString.
            // var varString = null;
            //
            // Lỗi vì phải khởi tạo giá trị ngay khi khai báo
            // var varLong;
            // varLong = 109;
            //
            // Khai báo đúng!
            // var varBool = true;

            #endregion

            #region VD_Var

            /* Vì biến StringVariable được khởi tạo giá trị kiểu chuỗi
             * nên trình biên dịch sẽ hiểu biến này như là biến kiểu string.
             */
            var varString = "HowKteam";
            // Khai báo tường minh biến kiểu string
            string Content = "HowKteam";
            
            // In giá trị của biến StringVariable và biến Content
            Console.WriteLine(varString);
            Console.WriteLine(Content);
            
            #endregion

            
            Console.ReadKey();
        }
    }
}