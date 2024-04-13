using System;

namespace SecondProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write();
            // Console.WriteLine();
            // Console.Read();
            // Console.ReadKey();
            // Console.ReadLine();

            #region Console.Write()
            // Console.Write("Kteam"); // In ra màn hình dòng chữ Kteam
            // Console.Write(10); // In ra màn hình số 10
            // Console.Write(10.9f); // In ra màn hình số 10.9 (f biểu thị cho kiểu dữ liệu float sẽ được trình bày chi tiết ở bài 5)
            // Console.Write(true); // In ra màn hình chữ true của kiểu dữ liêu bool (sẽ được trình bày chi tiết ở bài 5)
            #endregion

            #region Console.WriteLine()
            // Console.Write("K team \n"); // Sử dụng ký tự đặc biệt để xuống dòng
            // Console.WriteLine(5); // Sử dụng lệnh in ra màn hình có xuống dòng
            // Console.Write(6.5f); // In ra giá trị nhưng không xuống dòng
            // Console.Write(Environment.NewLine); // Sử dụng lệnh xuống 
            // Console.Write(true);
            //Ctrl + //
            //Ctrl + K + C/U
            
            // Console.Readline();
            
            #endregion

            int a = 5; // khai báo biến nguyên có tên là a và khởi tạo giá trị là 5
            Console.Write($"a = {a}\n"); // in ra màn hình giá trị a=
            //Console.Write(a); // in ra màn hình giá trị của a là 5
            Console.WriteLine("{0} {1} {2} {3}", 1,2,3,4);

            #region Console.Read()
            // Console.WriteLine(Console.Read()); // đọc 1 ký tự từ bàn phím bằng lệnh Console.Read() sau đó in ra ký tự vừa đọc 
            // Console.ReadKey(); // lệnh này đúng với mục đích dừng màn hình để xem kết quả

            #endregion

            #region Console.Readline()
            
            // Console.WriteLine(Console.ReadLine()); // đọc dữ liệu từ ký tự bàn phím cho đến khi gặp ký tự xuống dòng thì dừng. Sau đó in giá trị đã nhập ra màn hình
            // Console.ReadKey(); // lệnh này dùng với mục đích dừng màn hình để xem kết quả.
            
            #endregion

            #region Console.ReadKey()

            // Console.WriteLine("K team");
            //
            // Console.ReadKey(); // không truyền tham số vào thì mặc định là false
            // Console.ReadKey(false); // hiển thị phím ấn lên màn hình
            // Console.ReadKey(true); // Không hiển thị phím ấn lên màn hình

            #endregion
            
            Console.WriteLine("K team"); // In chữ "K team" sau đó xuống dòng
            Console.Write("Moi ban nhap ten cua minh: "); // In không xuống dòng.
            Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); 
            // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó.
            // Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine()
            // sau đó thực hiện cộng chuỗi và cuối cùng ra màn hình 
            
            Console.Write("Moi ban nhap ngay sinh: ");
            Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine());
            Console.Write("Moi ban nhap que quan: ");
            Console.WriteLine(" Que quan: " + Console.ReadLine());
            
            Console.ReadKey(); // đợi người dùng nhấn enter
            
        }
    }
}