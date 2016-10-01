using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
       public DTO_KhachHang(string _MaKH, string _TenKH, string _DiaChi,string _DienThoai, string _Email, string _GhiChu)
        {
            this.MaKH = _MaKH;
            this.TenKH = _TenKH;
            this.DiaChi = _DiaChi;
            this.DienThoai = _DienThoai;
            this.Email = _Email;
            this.GhiChu = _GhiChu;
        }
    }
}
