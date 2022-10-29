using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaSu.src.database;
using QuanLyGiaSu.src.models;

namespace QuanLyGiaSu.src.server
{
    public class Server
    {
        public TRUNGTAMGIASUDataContext _db = new TRUNGTAMGIASUDataContext();
        public Server() { }
        
        public object fetchAccountByUserName(string username)
        {
            var q = from p in _db.ACCOUNTs
                    where p.Username == username
                    select p;
            return q;

        }
        public object fetchAccount()
        {
            return _db.ACCOUNTs.Select(p => p);
        }

        /// <summary>
        /// Lấy dữ liệu bảng tin
        /// </summary>
        /// <returns></returns>
        public object fetchBangTinTable(){
            return _db.BANGTINs.Select(p => p);
        }

        /// <summary>
        /// Lấy dữ liệu lớp mới
        /// </summary>
        /// <returns></returns>
        public object fetchLopMoiPH_GSTable()
        {
            return _db.THONGTINLOPMOI_PH_Gs.Select(p => p);
        }
        //public object fetchLichSuGiaoDichTable(int id){
        //    return _db.select_lichsugiaodich(id);
        //}
        //public object fetchLichSuGiaoDichNapTienTable(){
        //    return _db.BANGTINs.Select(p => p);
        //}

        /// <summary>
        /// Lấy dữ liệu lớp mới cho AD
        /// </summary>
        /// <returns></returns>
        public object fetchDanhSachLopMoiAD()
        {
            return _db.THONGTINLOPMOI_ADs.Select(p => p);
        }

        public object fetchPhuHuynhAD()
        {
            return _db.PHUHUYNHs.Select(p => p);
        }

        public object fetchDanhSachDangKyDayAD()
        {
            return _db.DANHSACHDANGKYDAYs.Select(p => p);
        }

        /// <summary>
        /// Lấy dữ liệu lớp mà gia sư đăng ký dạy
        /// </summary>
        /// <param name="username">Tên đăng nhập của gia sư</param>
        /// <returns></returns>
        public object fetchDanhSachLopDaDangKyDayTable(string username)
        {
            return _db.select_danhsachlopmoi_dadangkyday(_db.check_ph_gs(_db.find_accid_username(username)));
        }

        public object fetchDanhSachLopDaMo_PhuHuynh(string username)
        {
            return _db.danhsachlop_damo(_db.check_ph_gs(_db.find_accid_username(username)));
        }

        /// <summary>
        /// Lấy thông tin lịch sử giao dịch của người dùng
        /// </summary>
        /// <param name="username">Tên đăng nhập</param>
        /// <returns></returns>
        public object fetchLichSuGiaoDichUserTable(string username)
        {
            return _db.select_lichsugiaodich(_db.find_accid_username(username));
        }   
        
        /// <summary>
        /// Lấy danh sách gia sư
        /// </summary>
        /// <returns></returns>
        public object fetchGiaSuTable()
        {
            return _db.THONGTINGIASU_ADs.Select(p => p);
        }    


        /// <summary>
        /// Add thông tin vào checkedlistbox
        /// </summary>
        /// <param name="clb"></param>
        public void addCheckedListBoxLopHoc(CheckedListBox clb)
        {
            foreach(var lb in _db.LOPHOCs)
            {
                clb.Items.Add(lb.TenLop);
            }
        }

        public void getThongTinGiaSu_private(string userName,ref int gsid,ref string ht, 
            ref string gt, ref DateTime ns,ref string dc, ref string sdt,ref string cmnd, 
            ref string qq, ref string td, ref string tdt, ref string ud, ref string email, ref string pw)
        {
            try
            {
                var a = _db.thongtingiasu_private(_db.find_accid_username(userName));

                if (a == null) return;
                foreach (var x in a)
                {
                    gsid = x.GSID;
                    ht = x.HoTen;
                    gt = x.GioiTinh;
                    ns = x.NgaySinh;
                    dc = x.DiaChi;
                    sdt = x.SDT;
                    cmnd = x.CMND;
                    qq = x.QueQuan;
                    td = x.TrinhDo;
                    tdt = x.TruongDaoTao;
                    ud = x.UuDiem;
                    email = x.Email;
                    pw = x.Password;
                    break;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getThongTinPhuHuynh_private(string userName, ref int phid, ref string ht,
            ref string gt, ref DateTime ns, ref string dc, ref string sdt, ref string cmnd,
             ref string email,ref string nghenghiep, ref string pw)
        {
            try
            {
                var a = _db.thongtinphuhuynh_private(_db.find_accid_username(userName));

                if (a == null) return;
                foreach (var x in a)
                {
                    phid = x.PHID;
                    ht = x.HoTen;
                    gt = x.GioiTinh;
                    ns = x.NgaySinh;
                    dc = x.DiaChi;
                    sdt = x.SDT;
                    cmnd = x.CMND;                    
                    email = x.Email;
                    nghenghiep = x.NgheNghiep;
                    pw = x.Password;
                    break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string checkAuthorization(string Username)
        {
            var x = _db.authorization_acc(Username);
            if (x == null)
                return "Admin";
            else
                return x.ToString();

        }

        /// <summary>
        /// Add thông tin vào checkedlistbox
        /// </summary>
        /// <param name="clb"></param>
        public void addCheckedListBoxMonHoc(CheckedListBox clb)
        {
            try
            {
                foreach (var lb in _db.MONHOCs)
                {
                    clb.Items.Add(lb.TenMon);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hash mật khẩu
        /// </summary>
        /// <param name="pass">Mật khẩu</param>
        /// <param name="userName">Tên đăng nhập</param>
        /// <returns></returns>
        public string hashPassWord(string pass, string userName)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(pass + userName);
            var hashPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashPassword);
        }

        /// <summary>
        /// Kiểm tra tài khoản đã tồn tại hay chưa
        /// </summary>
        /// <param name="userName">Tên đăng nhập</param>
        /// <param name="email">Email người dùng</param>
        /// <returns></returns>
        public bool isAccountExist(string userName, string email)
        {
            bool resultCheck = (bool)_db.check_username_email(userName, email);
            return resultCheck;
        }

        /// <summary>
        /// Thêm tài khoản
        /// </summary>
        /// <param name="account">Object account</param>
        /// <returns></returns>
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

        public void insertLopHocGiaSu(string userName, string tenLop)
        {
            try
            {
                _db.insert_lhgs(_db.check_ph_gs(_db.find_accid_username(userName)), _db.check_lhid(tenLop));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertMonHocGiaSu(string userName, string tenMon)
        {
            try
            {
                _db.insert_mhgs(_db.check_ph_gs(_db.find_accid_username(userName)), _db.check_mhid(tenMon));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật thông tin gia sư
        /// </summary>
        /// <param name="userName">Tên đăng nhập</param>
        /// <param name="name">Tên gia sư</param>
        /// <param name="cmnd">Chứng minh nhân dân</param>
        /// <param name="gender">Giới tính</param>
        /// <param name="birthday">Ngày sinh</param>
        /// <param name="phone">Số điện thoại</param>
        /// <param name="homeTown">Quê quán</param>
        /// <param name="address">Địa chỉ</param>
        /// <param name="school">Trường</param>
        /// <param name="level">Trình độ</param>
        /// <param name="strong">Điểm mạnh</param>
        /// <returns></returns>
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

        /// <summary>
        /// Cập nhật thông tin phụ huynh
        /// </summary>
        /// <param name="userName">Tên đăng nhập</param>
        /// <param name="name">Tên phụ huynh</param>
        /// <param name="phone">Số điện thoại</param>
        /// <param name="birthday">Ngày sinh</param>
        /// <param name="address">Địa chỉ</param>
        /// <param name="job">Nghề nghiệp</param>
        /// <param name="gender">Giới tính</param>
        /// <param name="cmnd">Chứng minh nhân dân</param>
        /// <returns></returns>
        public bool updateParent(
            string userName,
            string name,
            string phone,
            DateTime birthday,
            string address,
            string job,
            string gender,
            string cmnd
        )
        {
            try
            {
                _db.update_ph(
                    _db.check_ph_gs(_db.find_accid_username(userName)),
                    name,
                    cmnd,
                    gender,
                    birthday,
                    phone,
                    job,
                    address
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

        /// <summary>
        /// Kiểm tra đăng nhập
        /// </summary>
        /// <param name="userName">Tên đăng nhập</param>
        /// <param name="passHash">Hash mật khẩu</param>
        /// <param name="phanQuyen">Phân quyền</param>
        /// <returns></returns>
        public bool checkSignIn(string userName, string passHash, string phanQuyen)
        {
            return (bool)_db.check_signin(userName, passHash, phanQuyen);
        }

        public bool checkAdmin(string userName, string pw)
        {
            return (bool)_db.check_admin(userName, pw);
        }

        /// <summary>
        /// Lấy ngân sách
        /// </summary>
        /// <param name="userName">Tên đăng nhập</param>
        /// <returns></returns>
        public int getNganSach(String userName)
        {
            try
            {
                var temp = _db.select_ngansach(_db.find_accid_username(userName));
                if (temp != null)
                    return (int)temp;
                return 0;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

       
    }
}
