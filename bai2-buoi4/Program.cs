using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_buoi4
{
        public struct hocsinh
        {
            public string Ten;
            public int tuoi;
            public float diemtb;
        }
        class Program
        {
            static List<hocsinh> hsmoi = new List<hocsinh>();
            static void themhs()
            {
                hocsinh hsthem = new hocsinh();
                Console.Write("Nhập tên học sinh : ");
                hsthem.Ten = Console.ReadLine();
                Console.Write("Nhập tuổi hoc sinh : ");
                string tuoivao = Console.ReadLine();
                int tuoira;
                bool tuoilaso = int.TryParse(tuoivao, out tuoira);
                while (tuoilaso == false)
                {
                    Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                    tuoivao = Console.ReadLine();
                    tuoilaso = int.TryParse(tuoivao, out tuoira);
                    if ((tuoira < -2147483648) && (tuoira > 2147483647) && (tuoilaso == true))
                    {
                    Console.WriteLine("ban nhap so khong trong khoang int, xin moi nhap lai.");
                    tuoilaso = false;
                    }
                }
                hsthem.tuoi = tuoira;
                 Console.Write("Nhập điểm trung bình của học sinh : ");
                string diemvao = Console.ReadLine();
                float diemtb;
                bool diemlaso = float.TryParse(diemvao, out diemtb);
                while (diemlaso == false)
                {
                    Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                    diemvao = Console.ReadLine();
                    diemlaso = float.TryParse(diemvao, out diemtb);
                    if ((diemtb < -2147483648) && (diemtb > 2147483647)  && (diemlaso == true))
                    {
                        Console.WriteLine("ban nhap so khong trong khoang int, xin moi nhap lai.");
                        tuoilaso = false;
                    }
                }
                hsthem.diemtb = diemtb;
                hsmoi.Add(hsthem);
            }
            static void hienthihs()
            {
                foreach (hocsinh hshienthi in hsmoi)
                {
                    Console.WriteLine($"Tên hs : {hshienthi.Ten}, Tuổi hs : {hshienthi.tuoi}, Điểm tb hs : {hshienthi.diemtb}");
                }
            }
            static void timhs()
            {
                Console.Write("Nhập tên hs cần tìm : ");
                string tenvao = Console.ReadLine();
                foreach (var hstim  in hsmoi)
                {
                    if (hstim .Ten == tenvao)
                    { Console.WriteLine($"Tên hs: {hstim.Ten}, Tuổi hs : {hstim.tuoi}, điểm tb hs : {hstim.diemtb}"); }
                    else
                    {
                        Console.WriteLine("Không tìm thấy học sinh .");
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("1. Thêm học sinh mới");
                Console.WriteLine("2. Hiển thị danh sách học sinh ");
                Console.WriteLine("3. Tìm kiếm học sinh theo tên ");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chọn của bạn : ");
                string nhapvao = Console.ReadLine();
                int luachon;
                bool luachonlaso = int.TryParse(nhapvao, out luachon);
                while (luachonlaso == false)
                {
                    Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                    nhapvao = Console.ReadLine();
                    luachonlaso = int.TryParse(nhapvao, out luachon);
                    if ((luachon < -2147483648) && (luachon > 2147483647) && (luachonlaso == true))
                    {
                        Console.WriteLine("ban nhap so khong trong khoang int, xin moi nhap lai.");
                        luachonlaso = false;
                    }
                }
                switch (luachon)
                {
                    case 1:
                        themhs();
                        break;
                    case 2:
                        hienthihs();
                        break;
                    case 3:
                        timhs();
                        break;
                    case 4:
                        Console.WriteLine("thoát trương trình !");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
                Console.ReadKey();
            }
        }
}
