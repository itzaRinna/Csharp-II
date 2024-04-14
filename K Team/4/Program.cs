using System;

namespace FourthProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            // int? a = null;
			// string a = "HowToKteam";
			// char b = 'K';

			#region VD1

			// byte BienByte = 10;
			// short BienShort = 10;
			// int BienInt = 10;
			// long BienLong = 10;

			// // Kiểu số thực
			// float BienFloat = 10.9f; // Giá trị của biến float phải có hậu tố f hoặc F.
			// double BienDouble = 10.9; // Giá trị của biến kiểu double không cần hậu tố.
			// decimal BienDecimal = 10.9m; // Giá trị của biến kiểu decimal phải có hậu tố m.

			// // Kiểu ký tự và kiểu chuỗi
			// char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
			// string BienString "Kteam"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu "" (nháy kép).

			// Console.ReadKey();

			#endregion

			#region VD2
			
			// // Kiểu số nguyên
			// byte BienByte = 3;
			// short BienShort = 9;
			// int BienInt = 10;
			// long BienLong = 0;
			//
			// BienLong = BienByte; // BienLong có kiểu dữ liệu lớn hơn BienByte nên giá trị BienByte có thể gắn qua BienLong
			// Console.WriteLine(" BienLong = " + BienLong);
			//
			// BienLong = BienInt; // tương tự như trên
			// Console.WriteLine(" BienLong = {0}", BienLong);
			//
			// BienShort = BienByte; // tương tự như trên
			// Console.WriteLine(" BienShort = " + BienShort);
			//
			// BienInt = BienShort; // tương tự như trên
			// Console.WriteLine(" BienInt = " + BienInt); 
			//
			// Console.ReadKey();
			#endregion

			#region VD3

			// int a;
			// Console.WriteLine(" a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị.
			
			// int b = 10.9; // Lỗi vì b là biến kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên.
			
			// byte c = 1093; // Lỗi vì c là biến kiểu byte mà kiểu byte có miền giá trị từ -128 đến 127 nên không thể nhận giá trị ngoài vùng này được.
			
			// string d = 'K'; // Lỗi vì không thể gắn giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thể hiểu là tập hợp nhiều ký tự. Có thể sửa bằng cặp dấu "" thay vì ''.
			
			// long e = null; // Lỗi vì không thể gắn null cho biến kiểu long, int, byte, ...
			// long? f = null; // Cách khắc phục là thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?
			
			// int g = 10;
			// byte h = g; // Lỗi vì giá trị của biển có kiến dữ liệu lớn hơn không thể gắn cho biến có kiểu dữ liệu nhỏ hơn
			
			// string k = "KTeam";
			// Console.WriteLine(" k = " + K) // Lỗi vì phía trên khai báo biến k còn khi sử dụng là biến K (C# có phân biệt chữ hoa, chữ thường cần lưu ý để tránh gặp lỗi)

			// Console.ReadKey();

			#endregion

        }
    }
}
/*
 * KIỂU DỮ LIỆU
 * - Là tập hợp các nhóm dữ liệu có cùng đặc tính,
 * cách lưu trữ và thao tác xử lí trên trường dữ liệu đó
 * - Là một tính hiệu để trình biên dịch nhận biết kích thước của một biến và khả năng của nó
 * - Là thành phần cốt lõi của một ngôn ngữ lập trình
 * => dựng sẳn      || kiểu dữ liệu giá trị
 * => tự định nghĩa || kiểu dữ liệu tham chiếu
 */