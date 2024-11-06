using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhanhHang
{
    public class Dichvu
    {
        public int Madv { get; set; }
        public string Tendv { get; set; }
        public decimal Gia { get; set; }
        public Dichvu(int Masv ,string tendv, decimal gia)
        {
            this.Madv = Masv;
            Tendv = tendv;
            Gia = gia;
        }

        public Dichvu() { }
    }
    internal class QLDichvu
    {
        private List<Dichvu> qldv = new List<Dichvu>();
        //private int nextMadv = 1;

        public Dichvu Adddichvu(int Madv,string Tendv, decimal Gia)
        {
            var dv = new Dichvu
            {
                Madv = Madv,
                Tendv = Tendv,
                Gia = Gia
            };
            qldv.Add(dv);
            return dv;
        }
        public List<Dichvu> GEtAlldv()
        {
            return qldv;
        }
    }
}
