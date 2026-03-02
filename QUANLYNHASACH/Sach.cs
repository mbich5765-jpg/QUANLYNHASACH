using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHASACH
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public int GiaTien { get; set; }

        public Sach(string ma, string ten, string theLoai, int gia)
        {
            MaSach = ma;
            TenSach = ten;
            TheLoai = theLoai;
            GiaTien = gia;
        }
    }
}