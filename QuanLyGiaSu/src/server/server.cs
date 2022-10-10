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
            return _db.DANHSACHMOLOPs.Select(p => p);
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

        public bool isUserExist(string userName)
        {
            var tempData = from ACCOUNT in _db.ACCOUNTs
                           select new
                           {
                               UserName = userName,
                           };
            if (tempData != null) return true;
            return false;
        }

        public bool isEmailExist(string email)
        {
            var tempData = from ACCOUNT in _db.ACCOUNTs
            select new
                           {
                               Email = email,
                           };
            if (tempData != null) return true;
            return false;
        }

        public void registerAccount(AccountModel account)
        {
            ACCOUNT newAccount = new ACCOUNT
            {
                Email = account.Email,
                Username = account.UserName,
                Password = account.Password,
                PhanQuyen = account.PhanQuyen,
                NganSach = account.NganSach,
            };
            _db.ACCOUNTs.InsertOnSubmit(newAccount);
            _db.SubmitChanges();
        }
    }
}
