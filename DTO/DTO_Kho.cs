using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Kho
    {
        private string _MaKho;

        public string MaKho
        {
            get { return _MaKho; }
            set { _MaKho = value; }
        }
        private string _TenKho;

        public string TenKho
        {
            get { return _TenKho; }
            set { _TenKho = value; }
        }
        public DTO_Kho(string _MaKho, string _TenKho)
        {
            this.MaKho = _MaKho;
            this.TenKho = _TenKho;
        }
    }
}
