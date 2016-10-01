using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapKho
    {
        private string _MaKho;

        public string MaKho
        {
            get { return _MaKho; }
            set { _MaKho = value; }
        }
        
        private string _MaHH;

        public string MaHH
        {
            get { return _MaHH; }
            set { _MaHH = value; }
        }
        
        private string _MaNCC;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        
        private string _SoPN;

        public string SoPN
        {
            get { return _SoPN; }
            set { _SoPN = value; }
        }
        private string _SoLuong;

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _NgayNhap;

        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        private string _NoiDung;

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }
        public DTO_NhapKho(string _MaKho, string _MaHH,  string _MaNCC,  string _SoPN,string _SoLuong, string _NgayNhap, string _NoiDung)
        {
            this.MaKho = _MaKho;

            this._MaHH = _MaHH;

            this.MaNCC = _MaNCC;

            this.SoPN = _SoPN;
            this.SoLuong = _SoLuong;
            this.NgayNhap = _NgayNhap;
            this.NoiDung = _NoiDung;
        }
    }
}
