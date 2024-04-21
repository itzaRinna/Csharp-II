using System;

namespace _26thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cú pháp

            // struct <tên struct>
            // {
            // 	public <danh sách các biến>
            // }

            #endregion

            #region Chương Trình

            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien");

            SV1.NhapThongTinSinhVien(); // Call method on SV1 object
            Console.WriteLine("*************");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");

            SV1.XuatThongTinSinhVien(); // Call method on SV1 object

            Console.WriteLine(" Diem TB cua sinh vien la: " + SV1.DiemTBSinhVien()); // Call method on SV1 object

            Console.ReadKey();

            #endregion
        }

    }
    struct SinhVien
    {
        public int MaSo;
        public string HoTen;
        public double DiemToan;
        public double DiemLy;
        public double DiemVan;
        
        public void NhapThongTinSinhVien() // Method to input student information
        {
            Console.Write(" Ma so: ");
            string input = Console.ReadLine();
            int maSo;
            if (int.TryParse(input, out maSo)) // Safely parse input string
                MaSo = maSo;
            else
                Console.WriteLine("Invalid input for Ma so!");
            
            Console.Write(" Ho ten: ");
            HoTen = Console.ReadLine();
            
            Console.Write(" Diem toan: ");
            input = Console.ReadLine();
            double diemToan;
            if (double.TryParse(input, out diemToan)) // Safely parse input string
                DiemToan = diemToan;
            else
                Console.WriteLine("Invalid input for Diem toan!");
            
            Console.Write(" Diem ly: ");
            input = Console.ReadLine();
            double diemLy;
            if (double.TryParse(input, out diemLy)) // Safely parse input string
                DiemLy = diemLy;
            else
                Console.WriteLine("Invalid input for Diem ly!");
            
            Console.Write(" Diem van: ");
            input = Console.ReadLine();
            double diemVan;
            if (double.TryParse(input, out diemVan)) // Safely parse input string
                DiemVan = diemVan;
            else
                Console.WriteLine("Invalid input for Diem van!");
        }

        public void XuatThongTinSinhVien() // Method to display student information
        {
            Console.WriteLine(" Ma so: " + MaSo);
            Console.WriteLine(" Ho ten: " + HoTen);
            Console.WriteLine(" Diem toan: " + DiemToan);
            Console.WriteLine(" Diem ly: " + DiemLy);
            Console.WriteLine(" Diem van: " + DiemVan);
        }

        public double DiemTBSinhVien() // Method to calculate average grade
        {
            return (DiemToan + DiemLy + DiemVan) / 3;
        }

    }
}
