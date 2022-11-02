using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaSu.src.database;
using QuanLyGiaSu.src.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyGiaSu.src.server
{
    public class Server
    {
        public TRUNGTAMGIASUDataContext _db = new TRUNGTAMGIASUDataContext();
        public Server() { }

        #region Tim Kiem ADMIN

        #region Tim Kiem LSNT trong admin
        //Tìm kiếm LSNT theo Giao dịch ID
        public object TimKiemLSNT_GDID(int GDID)
        {
            return _db.timkiemlsnt_GDID(GDID);
        }
        //Tìm kiếm LSNT theo Account ID
        public object TimKiemLSNT_ACCID(int ACCID)
        {
            return _db.timkiemlsnt_ACCID(ACCID);
        }
        //Tìm kiếm LSNT theo Số tiền
        public object TimKiemLSNT_SoTien(int soTien)
        {
            return _db.timkiemlsnt_SoTien(soTien);
        }
        #endregion

        #region Tim Kiem LSGD trong admin
        //Tìm kiếm LSGD theo GDID
        public object TimKiemLSDG_GDID(int GDID)
        {
            return _db.timkiemlsgd_GDID(GDID);
        }
        //Tìm kiếm LSGD theo ACCID
        public object TimKiemLSDG_ACCID(int ACCID)
        {
            return _db.timkiemlsgd_ACCID(ACCID);
        }
        //Tìm kiếm LSGD theo LMID
        public object TimKiemLSDG_LMID(int LMID)
        {
            return _db.timkiemlsgd_LMID(LMID);
        }
        //Tìm kiếm LSGD theo SoTien
        public object TimKiemLSDG_SoTien(int SoTien)
        {
            return _db.timkiemlsgd_SoTien(SoTien);
        }
        //Tìm kiếm LSGD theo ThoiGianGiaoDich
        #endregion

        #region Tim Kiem Phu Huynh trong admin
        //Tìm kiếm phụ huynh theo PHID
        public object TimKiemPH_PHID(int PHID)
        {
            return _db.timkiemph_PHID(PHID);
        }
        //Tìm kiếm phụ huynh theo ACCID
        public object TimKiemPH_ACCID(int ACCID)
        {
            return _db.timkiemph_ACCID(ACCID);
        }
        //Tìm kiếm phụ huynh theo HoTen
        public object TimKiemPH_HoTen(string TenPH)
        {
            return _db.timkiemph_tenPH(TenPH);
        }
        #endregion

        #region Tim Kiem Gia Su trong admin
        //Tìm kiếm gia sư theo gsid
        public object TimKiemGiaSu_GSID(int GSID)
        {
            return _db.timkiemgs_GSID(GSID).Select(p => p);
        }

        //Tìm kiếm gia sư theo accid
        public object TimKiemGiaSu_ACCID(int ACCID)
        {
            return _db.timkiemgs_ACCID(ACCID);
        }
        //Tìm kiếm gia sư theo tên gia sư
        public object TimKiemGiaSu_TenGS(string tenGS)
        {
            return _db.timkiemgs_tenGS(tenGS);
        }
        //Tìm kiếm gia sư theo môn dạy
        public object TimKiemGiaSu_MonDay(string monDay)
        {
            return _db;
        }
        //Tìm kiếm gia sư theo lớp dạy
        public object TimKiemGiaSu_LopDay()
        {
            return _db;
        }
        #endregion

        #region Tim Kiem Account trong admin
        //Tìm kiếm account theo accid
        public object TimKiem_Account_ACCID(int accid)
        {
            return _db.timkiemaccount_accid(accid);
        }
        //Tìm kiếm account theo username
        public object TimKiem_Account_UserName(string username)
        {
            return _db.timkiemaccount_username(username);
        }
        #endregion

        #region Tim Kiem Lop Moi trong admin
        //Tìm kiếm lớp mới theo Mã lớp
        public object TimKiemLM_LMID(int LMID)
        {
            return _db.timkiemlm_LMID(LMID);
        }
        //Tìm kiếm lớp mới theo Lớp học
        //Tìm kiếm lớp mới theo Môn học

        #endregion

        #endregion

        #region Tim Kiem GIASU

        #region Tim kiem Lop Moi trong Gia Su(Đã có)
        #endregion

        #region Tim Kiem DSDK day trong Gia Su
        //Tìm kiếm DSDK Theo Mã Lớp
        public object TimKiemDSDK_LMID(int LMID)
        {
            return _db;
        }
        #endregion

        #endregion

        #region Tim Kiem PHUHUYNH

        #endregion

        public void setLSNTByUSerName(String userName, int value, DateTime date)
        {
            _db.insert_lsnt(_db.find_accid_username(userName), value, date);
        }

        public List<string> fetchLopHoc()
        {
            try
            {
                return _db.LOPHOCs.Select(p => p.TenLop).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<string> fetchMonHoc()
        {
            try
            {
                return _db.MONHOCs.Select(p => p.TenMon).ToList();
            }
            catch
            {
                return null;
            }
        }
        
        /// <summary>
        /// Lấy dữ liệu account bằng UserName
        /// </summary>
        /// <param name="UserName">Tên người dùng</param>
        /// <returns></returns>
        public object fetchAccountByUserName(string UserName)
        {
            try
            {
                var q = from p in _db.ACCOUNTs
                        where p.Username == UserName
                        select p;
                return q;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        /// <summary>
        /// Lấy dữ liệu account
        /// </summary>
        /// <returns></returns>
        public object fetchAccount()
        {
            try
            {
                return _db.ACCOUNTs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu bảng tin
        /// </summary>
        /// <returns></returns>
        public object fetchBangTinTable(){
            try
            {
                return _db.BANGTINs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu lớp mới
        /// </summary>
        /// <returns></returns>
        public object fetchLopMoiPH_GSTable()
        {
            try
            {
                return _db.THONGTINLOPMOI_PH_Gs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
            try
            {
                return _db.THONGTINLOPMOI_ADs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu phụ huynh
        /// </summary>
        /// <returns></returns>
        public object fetchPhuHuynhAD()
        {
            try
            {
                return _db.THONGTINPHUHUYNH_ADs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu danh sách dạy
        /// </summary>
        /// <returns></returns>
        public object fetchDanhSachDangKyDayAD()
        {
            try
            {
                return _db.DANHSACHDANGKYDAYs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu lớp mà gia sư đăng ký dạy
        /// </summary>
        /// <param name="UserName">Tên đăng nhập của gia sư</param>
        /// <returns></returns>
        public object fetchDanhSachLopDaDangKyDayTable(string UserName)
        {
            try
            {
                return _db.select_danhsachlopmoi_dadangkyday(_db.check_ph_gs(_db.find_accid_username(UserName)));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy danh sách lớp phụ huynh có UserName đã mở
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <returns></returns>
        public object fetchDanhSachLopDaMo_PhuHuynh(string UserName)
        {
            try
            {
                return _db.danhsachlop_damo(_db.check_ph_gs(_db.find_accid_username(UserName)));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy thông tin lịch sử giao dịch của toàn bộ người dùng
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <returns></returns>
        
        public object fetchLishSuGiaoDich()
        {
            return _db.THONGTINLICHSUGIAODICH_ADs.Select(p => p);
        }

        /// <summary>
        /// Lấy thông tin lịch sử nạp tiền của toàn bộ người dùng
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <returns></returns>

        public object fetchLishSuNapTienh()
        {
            return _db.THONGTINLICHSUNAPTIEN_ADs.Select(p => p);
        }
        public object fetchLichSuGiaoDichUserTable(string UserName)
        {
            try
            {
                return _db.select_lichsugiaodich(_db.find_accid_username(UserName));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy thông tin lịch sử nạp tiền của người dùng
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <returns></returns>
        public object fetchLichSuNapTienUserTable(string UserName)
        {
            try
            {
                return _db.select_lichsunaptien(_db.find_accid_username(UserName));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy danh sách gia sư
        /// </summary>
        /// <returns></returns>
        public object fetchGiaSuTable()
        {
            try
            {
                return _db.THONGTINGIASU_ADs.Select(p => p);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }    


        /// <summary>
        /// Add thông tin vào checkedlistbox
        /// </summary>
        /// <param name="clb"></param>
        public void addCheckedListBoxLopHoc(CheckedListBox clb)
        {
            try
            {
                foreach (var lb in _db.LOPHOCs)
                {
                    clb.Items.Add(lb.TenLop);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lấy thông tin cá nhân gia sư
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="GSID"></param>
        /// <param name="HoTen"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="DiaChi"></param>
        /// <param name="Sdt"></param>
        /// <param name="Cmnd"></param>
        /// <param name="QueQuan"></param>
        /// <param name="TrinhDo"></param>
        /// <param name="TruongDaoTao"></param>
        /// <param name="UuDiem"></param>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns>true nếu lấy được dữ liệu
        /// false nếu không lấy được dữ liệu</returns>
        public bool getThongTinGiaSu_private(string UserName, ref int GSID, ref string HoTen,
            ref string GioiTinh, ref DateTime NgaySinh, ref string DiaChi, ref string Sdt, ref string Cmnd,
            ref string QueQuan, ref string TrinhDo, ref string TruongDaoTao, ref string UuDiem, ref string Email, ref string Password)
        {
            try
            {
                var a = _db.thongtingiasu_private(_db.find_accid_username(UserName));

                if (a == null) return false ;
                foreach (var x in a)
                {
                    GSID = x.GSID;
                    HoTen = x.HoTen;
                    GioiTinh = x.GioiTinh;
                    NgaySinh = x.NgaySinh;
                    DiaChi = x.DiaChi;
                    Sdt = x.SDT;
                    Cmnd = x.CMND;
                    QueQuan = x.QueQuan;
                    TrinhDo = x.TrinhDo;
                    TruongDaoTao = x.TruongDaoTao;
                    UuDiem = x.UuDiem;
                    Email = x.Email;
                    Password = x.Password;
                    break;
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// Lấy thông tin cá nhân phụ huynh
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="PHID"></param>
        /// <param name="HoTen"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="DiaChi"></param>
        /// <param name="Sdt"></param>
        /// <param name="Cmnd"></param>
        /// <param name="Email"></param>
        /// <param name="NgheNghiep"></param>
        /// <param name="Password"></param>
        /// <returns>true nếu lấy được dữ liệu
        /// false nếu không lấy được dữ liệu</returns>
        public bool getThongTinPhuHuynh_private(string UserName, ref int PHID, ref string HoTen,
            ref string GioiTinh, ref DateTime NgaySinh, ref string DiaChi, ref string Sdt, ref string Cmnd,
             ref string Email,ref string NgheNghiep, ref string Password)
        {
            try
            {
                var a = _db.thongtinphuhuynh_private(_db.find_accid_username(UserName));

                if (a == null) return false;
                foreach (var x in a)
                {
                    PHID = x.PHID;
                    HoTen = x.HoTen;
                    GioiTinh = x.GioiTinh;
                    NgaySinh = x.NgaySinh;
                    DiaChi = x.DiaChi;
                    Sdt = x.SDT;
                    Cmnd = x.CMND;                    
                    Email = x.Email;
                    NgheNghiep = x.NgheNghiep;
                    Password = x.Password;
                    break;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra phân quyền
        /// </summary>
        /// <param name="UserName">Tên người dùng</param>
        /// <returns>Phân quyền</returns>
        public string checkAuthorization(string UserName)
        {
            try
            {
                var x = _db.authorization_acc(UserName);
                if (x == null)
                    return "Admin";
                else
                    return x.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Phụ huynh";
            }

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
        /// <param name="UserName">Tên đăng nhập</param>
        /// <returns></returns>
        public string hashPassWord(string pass, string UserName)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(pass + UserName);
            var hashPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashPassword);
        }

        /// <summary>
        /// Kiểm tra tài khoản đã tồn tại hay chưa
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="email">Email người dùng</param>
        /// <returns></returns>
        public bool isAccountExist(string UserName, string email)
        {
            try
            {
                bool resultCheck = (bool)_db.check_username_email(UserName, email);
                return resultCheck;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

        /// <summary>
        /// Thêm tài khoản
        /// </summary>
        /// <param name="account">Object account</param>
        /// <returns></returns>
        public bool insertDSDK(string Username, int LMID, DateTime TGDK)
        {
            try
            {
                _db.insert_dsdk(_db.check_ph_gs(_db.find_accid_username(Username)), LMID, TGDK);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Thêm lớp dạy cho gia sư
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="tenLop"></param>
        /// <returns></returns>
        public bool insertLopHocGiaSu(string UserName, string tenLop)
        {
            try
            {
                _db.insert_lhgs(_db.check_ph_gs(_db.find_accid_username(UserName)), _db.check_lhid(tenLop));
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Thêm môn học cho gia sư
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="tenMon"></param>
        /// <returns></returns>
        public bool insertMonHocGiaSu(string UserName, string tenMon)
        {
            try
            {
                _db.insert_mhgs(_db.check_ph_gs(_db.find_accid_username(UserName)), _db.check_mhid(tenMon));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Thêm môn học cho lớp mới
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="tenMon"></param>
        /// <returns></returns>
        public bool insertMonHocLopMoi(int LMID, string tenMon)
        {
            try
            {
                if (_db.insert_mhlm(LMID, _db.check_mhid(tenMon)) == 1) return true;
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Thêm lớp mới
        /// </summary>
        /// <param name="TenLop"></param>
        /// <param name="UserName"></param>
        /// <param name="DiaChi"></param>
        /// <param name="MucLuong"></param>
        /// <param name="Sdt"></param>
        /// <param name="ThoiGianDK"></param>
        /// <param name="SoBuoi"></param>
        /// <param name="HinhThuc"></param>
        /// <param name="ThoiGianHoc"></param>
        /// <param name="ThongTinHocVien"></param>
        /// <param name="YeuCau"></param>
        /// <returns></returns>
        public bool insertDSML(string TenLop, string UserName, string DiaChi, int MucLuong,
            string Sdt, DateTime ThoiGianDK, int SoBuoi, string HinhThuc, string ThoiGianHoc,
            string ThongTinHocVien, string YeuCau, ref int LMID)
        {
            try
            {
                LMID=_db.insert_dsml(_db.check_lhid(TenLop), _db.check_ph_gs(_db.find_accid_username(UserName)), DiaChi, MucLuong, Sdt, ThoiGianDK, SoBuoi, HinhThuc, ThoiGianHoc, ThongTinHocVien, YeuCau);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LMID = 0;
                return false;
            }
        }

        public bool updateAccount(AccountModel acc)
        {
            try
            {
                _db.update_acc(_db.find_accid_username(acc.UserName), acc.UserName, hashPassWord(acc.Password, acc.UserName), acc.Email);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Thiếu hoặc sai dữ liệu! \nXin vui lòng nhập đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Cập nhật thông tin gia sư
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
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
            string UserName, 
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
                    _db.check_ph_gs(_db.find_accid_username(UserName)),
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
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="name">Tên phụ huynh</param>
        /// <param name="phone">Số điện thoại</param>
        /// <param name="birthday">Ngày sinh</param>
        /// <param name="address">Địa chỉ</param>
        /// <param name="job">Nghề nghiệp</param>
        /// <param name="gender">Giới tính</param>
        /// <param name="cmnd">Chứng minh nhân dân</param>
        /// <returns></returns>
        public bool updateParent(
            string UserName,
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
                    _db.check_ph_gs(_db.find_accid_username(UserName)),
                    name,
                    cmnd,
                    gender,
                    birthday,
                    phone,
                    job,
                    address
                );
                MessageBox.Show("Cập nhập thông tin thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <param name="UserName">Tên đăng nhập</param>
        /// <param name="PassHash">Hash mật khẩu</param>
        /// <param name="PhanQuyen">Phân quyền</param>
        /// <returns></returns>
        public bool checkSignIn(string UserName, string PassHash, string PhanQuyen)
        {
            try
            {
                return (bool)_db.check_signin(UserName, PassHash, PhanQuyen);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra đăng nhập Admin
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool checkAdmin(string UserName, string Password)
        {
            try
            {
                return (bool)_db.check_admin(UserName, Password);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Lấy ngân sách
        /// </summary>
        /// <param name="UserName">Tên đăng nhập</param>
        /// <returns></returns>
        public int getNganSach(String UserName)
        {
            try
            {
                var temp = _db.select_ngansach(_db.find_accid_username(UserName));
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
        public string getUsername(int accid)
        {
            
            return _db.find_username_accid(accid);
        }
        public string getEmail(int accid)
        {

            return _db.find_email_accid(accid);
        }

    }
}
