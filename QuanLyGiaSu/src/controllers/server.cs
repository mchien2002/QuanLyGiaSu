using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaSu.src.database;
using QuanLyGiaSu.src.models;

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
            return _db.select_lichsugiaodich(id);
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

        public bool addAccount(AccountModel account)
        {
            try
            {
                _db.insert_acc(account.PhanQuyen, account.UserName, account.Password, account.Email, account.NganSach = 0);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool updateInfoTutor(
            string userName, 
            string name, 
            string cmnd, 
            string gender, 
            DateTime birthday, 
            string phone,
            string homeTown, 
            string address,
            string school,
            string level,
            string strong
        )
        {
            try
            {
                _db.update_gs(
                    _db.check_ph_gs(_db.find_accid_username(userName)),
                    name,
                    cmnd,
                    gender,
                    birthday,
                    phone,
                    homeTown,
                    school,
                    level,
                    strong,
                    address,
                    null
                );
                MessageBox.Show("Đăng ký thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            catch
            {
                MessageBox.Show("Thiếu hoặc sai dữ liệu! \nXin vui lòng nhập đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void updateParent(
            AccountModel account,
            string name,
            string cmnd,
            string gender,
            DateTime birthday,
            string phone,
            string job,
            string location
        )
        {

        }
    }
}
