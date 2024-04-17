using System;

namespace SeventhProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chuyển kiểu ngầm định

            // int k = 10;
            // long l = k; // Chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển từ int sang long.
            // float f = 10.9f;
            // double d = f; // Tương t vì kiểu double có min giá trị lớn hơn kiểu float nên có thể chuyển từ float sang double.

            #endregion

            #region Chuyển kiểu tường minh

            // int i = 300; // 300 có mã nhị phân là 100101100
            // byte b = (byte)i; // do kiểu byte có giới hạn đến giá trị 225
            //                   // nên không thể chứa số 300 được mà kiểu byte có kích thước là 1 byte tương đương 8 bit.
            //                   // Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là được.
            //                   // Mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit)
            //                   // tương đương với số 44. Cuối cùng biến b sẽ mang giá trị là 44.  
            //
            // Console.WriteLine(" i = " + i);
            // Console.WriteLine(" b = " + b);
            //
            // int a = 5;
            // int c = 2;
            // float tt = (float)a / c; // =>2.5
            //
            // double d = 2 / 3; // kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện 2 chia lấy phần nguyên với 3 được 0
            // double k = (double)2 / 3; // Ép kiểu số 2 từ kiu nguyên sang kiểu số thực . Như vậy kết quả phép chia sẽ ra số thực
            // double t = 1.0 * 2 / 3; // Thực hiện nhân 1.0 với 2 mục đích để biến số 2 ( số nguyên ) thành 2.0 (số thực)
            //
            // Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d,k,t);
            //
            // Console.ReadKey();

            #endregion

            #region Parse()

            // string s = "10";
            // int k = int.Parse(s); // Chuyễn chuỗi s sang kiểu int và lưu giá trị vào biến k - Kết quả k = 10
            // double e = double.Parse("10.9"); // Chuyến chuỗi giá trị hằng "10.9" sang kiểu int và lưu giá trị vào biến e - Kết quả e = 10.9 

            #endregion

            #region TryParse()

            // int Result; // Biến chứa giá trị kết quả khi ép kiểu thành công
            // bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
            // string Data1 = "10", Data2 = "Kteam"; // Dữ liệu cần ép kiểu
            //
            // isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. Ngược lại Result sẽ mang giá trị 0 và isSuccess mang giá trị false
            // Console.WriteLine(isSuccess == true? "Success !" : "Failed!"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
            // Console.WriteLine(" Result = " + Result); // In giá trị Result ra màn hình
            //
            // isSuccess = int.TryParse(Data2, out Result); // Tương tự như trên nhưng với Data2
            // Console.WriteLine(isSuccess == true? "Success !" : "Failed!"); // Tương tự như trên
            // Console.WriteLine(" Result = " + Result); // Tương tự như trên

            #endregion
            
            int A, B; // Biến chứa giá trị 2 số vừa nhập vào (kiểu số)
            int Tong, Hieu, Tich; // Biến chứa kết quả tổng, hiệu, tích
            double Thuong; // Vì phép chia có thể cho ra số thập phân nên dùng biến kiểu double để chứa nó.
            string strA, strB; // Biến chứa giá trị 2 số nhập vào từ bàn phím (kiểu chuỗi)

            Console.WriteLine("         **************************************************");
            Console.WriteLine("         *                                         			       *");
            Console.WriteLine("         *   Chuong trinh tinh tong, hieu, tich, thuong  *");
            Console.WriteLine("         *                                            		       *");
            Console.WriteLine("         **************************************************");

            Console.Write("\n Moi ban nhap so A: ");
            strA = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số A
            Console.Write(" Moi ban nhap so B: ");
            strB = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số B

            A = int.Parse(strA); // Ép kiểu giá trị nhập vào từ kiễu chuỗi sang kiểu số nguyên, sử dụng phương thức Parse()
            B = int.Parse(strB); // Tương tự

            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B; // Ép kiểu số A về số thập phân để phép chia cho ra số thập phân

            Console.WriteLine(" Tong = " + Tong);
            Console.WriteLine(" Hieu = " + Hieu);
            Console.WriteLine(" Tich = " + Tich);
            Console.WriteLine(" Thuong = " + Thuong);

        }
    }
}
/*
 * Chuyển đổi mặc định
 * Chuyển đổi tường minh
 * Sử dụng phương thức, lớp hỗ trợ sẳn
 * Người dùng tự định nghĩa kiểu chuyển đổi => Parse(), TryParse(), Convert
 */