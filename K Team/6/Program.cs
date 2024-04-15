using System;

namespace SixthProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 15;
            const int x = a;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
/*
 * - Hằng là một biến nhưng giá trị không thay đổi trong suốt chương trình
 * - Bắt buộc phải khởi tạo giá trị khi khai báo
 *
 * - Để ngăn chặn việc gán giá trị khác vào
 * - Hằng làm cho chương trình dễ đọc hơn bằng các biến những con sốt vô cảm thành những tên có ý nghĩa
 * - Hằng giúp cho chương trình dễ nâng cắp, dễ sửa chữa hơn
 * - Hằng giúp cho ciệc tránh lỗi dễ dàng hơn
 */