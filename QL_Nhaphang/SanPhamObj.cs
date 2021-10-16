using System;
using System.Collections.Generic;
using System.Text;

namespace QL_Nhaphang
{
    class SanPhamObj
    {
        string ma, ten, soluong, maloai, mabst, hinhanh, kichthuoc, dongia;
public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Maloai { get => maloai; set => maloai = value; }
        public string Mabst { get => mabst; set => mabst = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Kichthuoc { get => kichthuoc; set => kichthuoc = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public SanPhamObj() { }
        public SanPhamObj(string ma, string ten, string soluong, string maloai, string mabst, string hinhanh, string kichthuoc, string dongia)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
            this.maloai = maloai;
            this.mabst = mabst;
            this.hinhanh = hinhanh;
            this.kichthuoc = kichthuoc;
            this.dongia = dongia;
        }
    }
}
