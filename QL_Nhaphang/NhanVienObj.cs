using System;
using System.Collections.Generic;
using System.Text;

namespace QL_Nhaphang
{
    class NhanVienObj
    {
        string ma, hoten, gioitinh, diachi;
        DateTime namsinh;

        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public NhanVienObj() { }
        public NhanVienObj(string ma, string hoten,DateTime namsinh, string gioitinh, string diachi)
        {
            this.ma = ma;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
        }
    }
}
