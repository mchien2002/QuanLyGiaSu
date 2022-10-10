using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaSu.src.database.database_local;
using QuanLyGiaSu.src.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyGiaSu.src.server
{
    public class Server
    {
        public TRUNGTAMGIASUDataContext _db =  new TRUNGTAMGIASUDataContext();
        public Server() { }
        
        public object fetchBangTinTable(){
            return _db.BANGTINs.Select(p => p);
        }
        public object fetchLopMoiTable(){
            return _db.THONGTINLOPMOI_PH_Gs.Select(p => p);
        }
        public object fetchLichSuGiaoDichTable(int id){
            return _db.select_lichsugiaodich_gs(id);
        }
        public object fetchLichSuGiaoDichNapTienTable(){
            return _db.BANGTINs.Select(p => p);
        }
        public string hashPassWord(string pass, string userName)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(pass + userName);
            var hashPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashPassword);
        }

        // CHECK USER ĐÃ TỒN TẠI CHƯA
        public bool isAccountExist(string userName, string email)
        {
            bool resultCheck = (bool)_db.check_username_email(userName, email);
            return resultCheck;
        }

        public void postAccount(AccountModel account)
        {
            _db.insert_acc(account.PhanQuyen, account.UserName, account.Password, account.Email, account.NganSach);
        }
    }
}
