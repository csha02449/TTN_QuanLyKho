using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class DTO_DangNhap
    {
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _PassWord;

        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
         private int _Quyen;

public int Quyen
{
  get { return _Quyen; }
  set { _Quyen = value; }
}
public DTO_DangNhap(string _UserName, string _PassWord, int _Quyen)
        {
            this.UserName = _UserName;
            this.PassWord = _PassWord;
            this.Quyen = _Quyen;

         

        }
    }
}
