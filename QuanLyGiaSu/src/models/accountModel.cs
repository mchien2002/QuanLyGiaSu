using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaSu.src.models
{
    public class AccountModel
    {
        private string _phanQuyen;
        private string _userName;
        private string _password;
        private string _email;
        private int _nganSach;

        public string phanQuyen { get { return _phanQuyen; } set { _phanQuyen = value; } }
        public string userName { get { return _userName; } set { _userName = value; } }
        public string password { get { return _password; } set { _password = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public int nganSach { get { return _nganSach; } set { _nganSach = value; } }

        public AccountModel()
        {
            nganSach = 0;
        }

        public AccountModel(string phanQuyen, string userName, string password, string email, int nganSach)
        {
            this.phanQuyen = phanQuyen;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.nganSach = nganSach;
            this.phanQuyen = phanQuyen;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.nganSach = nganSach;
        }
    }
}
