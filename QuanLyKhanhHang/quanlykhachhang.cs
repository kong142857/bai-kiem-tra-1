using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class Khachhang
    {
        public int Makh { get; set; }
        public string Tenkh { get; set; }
        public string Sdt { get; set; }
        public string Diachi { get; set; }
    }
    internal class quanlykhachhang
    {
       
        private List<Khachhang> qlkh = new List<Khachhang>();
        private int nextMakh = 1;
        public List<Khachhang> GetAllKh()
        {
            return qlkh;
        }
        public Khachhang AddKhachhang(string Tenkh, string Sdt, string Diachi)
        {
            var kh = new Khachhang
            {
                Makh = nextMakh++,
                Tenkh = Tenkh,
                Sdt = Sdt,
                Diachi = Diachi
            };
            qlkh.Add(kh);
            return kh;
        }
        public bool EditKh(int Makh, string Tenkh, string Sdt, string Diachi)
        {
            var khachhang =qlkh.FirstOrDefault(c=> c.Makh == Makh);
            if(khachhang != null)
            {
                khachhang.Tenkh = Tenkh;
                khachhang.Sdt = Sdt;
                khachhang.Diachi = Diachi;
                return true;
            }
            return false;
        }

        public bool DeleteKh(int Makh)
        {
            var khachhang = qlkh.FirstOrDefault(c=>c.Makh == Makh);
            if(khachhang != null)
            {
                qlkh.Remove(khachhang);
                return true;

            }
            return false;
        }
    }

}
