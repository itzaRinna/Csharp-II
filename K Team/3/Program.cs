using System;

namespace ThirdProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  <Kiểu dữ liệu> <Tên biến>;
             */

            int KieuSoNguyen = 5;
            float BienKieuSoThuc = 6.9f;
            string BienKieuChuoi = "HowKTeam.com - Free Education";
            bool BienKieuLuanLy = true;
            char BienKIeuKyTu = 'K';

            int aNum = 6;
            int bNum = 9;
            int cNum = aNum + bNum;

            // In giá trị của biến KieuSoNguyen ra màn hình => 5
            Console.WriteLine(KieuSoNguyen);
            Console.WriteLine(BienKieuChuoi);
            Console.WriteLine("{0} + {1} = {2}", aNum,bNum,cNum);

            Console.ReadKey();
        }
    }
}
// BIẾN LÀ GÌ??
// biến -> có thể thay đổi
/*
 * Biến:
 * - là một giá trị có thể thay đổi được
 * - là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ
 * - là thành phần cốt lõi của một ngôn ngữ lập trình
 */
            
// => Why??
            
/*
 * - Lưu trữ dữ liệu và tái sử dụng
 * - Thao tác với bộ nhớ một cách dễ dàng
 */
//============================================================================

/* QUY TẮC ĐẶT TÊN BIẾN
 *
 * - Tên biến là một chuỗi kí tự liên kết (không có khoảng trắng) và ko chứa ký tự đặt biệt
 * - Tên biến không được đặt bằng tiếng Việt có dấu
 * - Tên biến không được đặt bằng số
 * - Tên biến không được trùng nhau
 * - Tên biến không được trùng với từ khóa
 */
 
/*
 * Quy tắc lạc đà:
 * - Viết thường từ đầu tiên và viết hoa chữ cái đầu tiên của những từ tiếp theo -> howKteamFreeEducation
 * - Thường dùng cho private, protected
 */ 
 
/*
 * Quy tắc pascal:
 * - Viết hoa chữ cái đầu tiên của mỗi từ -> HowKteamFreeEducation
 * - Đặt tên cho hàm, class, object, interface, enum, event và etc.
 */ 

/*
 *  - Nên đặt tên ngắn gọn dễ hiểu
 *  - Thể hiện rõ mục đích của biến
 *  - 
 */ 