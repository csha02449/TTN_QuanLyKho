using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_XuatKho
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
       
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        
        private string _SoPX;

        public string SoPX
        {
            get { return _SoPX; }
            set { _SoPX = value; }
        }
        private string _SoLuong;

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _NgayXuat;

        public string NgayXuat
        {
            get { return _NgayXuat; }
            set { _NgayXuat = value; }
        }
        private string _NoiDung;

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }
        public DTO_XuatKho(string _SoPX, string _MaKho,  string _NgayXuat,  string _MaKH,string _NoiDung, string _MaHH, string _SoLuong)
        {                  
            this.MaKho = _MaKho;

            this._MaHH = _MaHH;

            this.MaKH = _MaKH;

            this.SoPX = _SoPX;
            this.SoLuong = _SoLuong;
            this.NgayXuat = _NgayXuat;
            this.NoiDung = _NoiDung;
        }
    }
}
