using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NCC
    {
        private string _MaNCC;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        private string _TenNCC;

        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
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
        public DTO_NCC(string _MaNCC,string _TenNCC, string _DiaChi,string _DienThoai, string _Email, string _GhiChu)
        {
            this.MaNCC = _MaNCC;
            this.TenNCC = _TenNCC;
            this.DiaChi = _DiaChi;
            this.DienThoai = _DienThoai;
            this.Email = _Email;
            this.GhiChu = _GhiChu;
        }
    }
}
