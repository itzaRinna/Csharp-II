using System;

namespace _21stProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cú pháp khai báo, khởi tạo, cấp phát vùng nhớ cho mảng 1 chiều

            /*
             * Khai báo mảng 1 chiều kiểu string và có tên là Kteam.
             * Sau đó thực hiện cấp phát vùng nhớ với số phần tử tối đa của mảng là 3.
             */

            // string[] Array = new string[3];
            
            /*
             * Khởi tạo giá trị ngay khi cấp phát vùng nhớ
             * Sau câu lệnh này thì mảng Kteam sẽ có 2 phần tử mang 2 giá trị là "HowKteam" và "Free Education"
             */
            
            // string[] Kteam = new string[] { "HowKteam", "Free Education" };
            /*
             * Vì chỉ số phần tử được đánh số từ 0 nên muốn truy xuất đến phần tử thứ 2 của mảng
             * thì chỉ số phần tử là 1
             */  
            // int[] IntArray = { 3, 9, 10 };
            //
            // Console.WriteLine(Kteam[1]);

            #endregion

            #region Ví dụ chương trình sử dụng mảng

            // int Year; // Biến chứa giá trị năm cần tính.
            // Mảng Can chứa các giá trị can tương ứng theo bảng can
            // string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            // Mảng Chi chứa các giá trị chi tương ứng theo bảng chi
            // string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };


            // Console.Write(" Moi ban nhap mot nam bat ky: ");

            // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            // Year = Int32.Parse(Console.ReadLine());


            /*
             * Vì kết quả phép chia lấy dư của Year%10 hoặc Year%12 sẽ cho ra số nguyên
             * Nên ta sẽ dùng nó làm chỉ số phần tử để tra cứu ra giá trị can chi tương ứng. Thay vì dùng cách cũ là switch case
             * Như vậy cách này vừa đơn giản vừa dễ hiểu, code rất ít sẽ với cách dùng switch case
             */

            // Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year%10], Chi[Year%12]); // Nối Can và Chi lại để được năm âm lịch
            
            #endregion

            #region VD_Finale

            string[] HoTenSinhVien = new string[5];

            for (int i = 0; i < HoTenSinhVien.Length; i++)
            {
                HoTenSinhVien[i] = Console.ReadLine();
            }

            Console.WriteLine();
            
            for (int i = 0; i < HoTenSinhVien.Length; i++)
            {
                Console.WriteLine(HoTenSinhVien[i]);
            }

            #endregion

            Console.ReadKey();
        }
    }
}