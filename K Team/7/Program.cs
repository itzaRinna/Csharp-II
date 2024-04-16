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

            int i = 300; // 300 có mã nhị phân là 100101100
            byte b = (byte)i; // do kiểu byte có giới hạn đến giá trị 225
                              // nên không thể chứa số 300 được mà kiểu byte có kích thước là 1 byte tương đương 8 bit.
                              // Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là được.
                              // Mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit)
                              // tương đương với số 44. Cuối cùng biến b sẽ mang giá trị là 44.  

            Console.WriteLine(" i = " + i);
            Console.WriteLine(" b = " + b);

            int a = 5;
            int c = 2;
            float tt = (float)a / c; // =>2.5
            
            double d = 2 / 3; // kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện 2 chia lấy phần nguyên với 3 được 0
            double k = (double)2 / 3; // Ép kiểu số 2 từ kiu nguyên sang kiểu số thực . Như vậy kết quả phép chia sẽ ra số thực
            double t = 1.0 * 2 / 3;

            Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d,k,t);

            Console.ReadKey();

            #endregion

            #region Parse()



            #endregion

            #region TryParse()



            #endregion

        }
    }
}
/*
 * Chuyển đổi mặc định
 * Chuyển đổi tường minh
 * Sử dụng phương thức, lớp hỗ trợ sẳn
 * Người dùng tự định nghĩa kiểu chuyển đổi => Parse(), TryParse(), Convert
 */