using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_HangHoa
    {
        private string _MaHH;

        public string MaHH
        {
            get { return _MaHH; }
            set { _MaHH = value; }
        }
        private string _TenHH;

        public string TenHH
        {
            get { return _TenHH; }
            set { _TenHH = value; }
        }
        private string _DVT;

        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
       public DTO_HangHoa(string _MaHH, string _TenHH, string _DVT)
        {
            this.MaHH = _MaHH;
            this.TenHH = _TenHH;
            this.DVT = _DVT;
        }
    }
}
