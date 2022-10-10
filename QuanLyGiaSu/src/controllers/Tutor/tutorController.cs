using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using QuanLyGiaSu.database;
using QuanLyGiaSu.database.database_local;
using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.controllers.Tutor
{
    class TutorController : BaseController
    {
        public TutorController()
        {
            _db = new TRUNGTAMGIASUDataContext();
        }

        public override void registerAccount(AccountModel account)
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

        public override void showBangTinTable(DataGridView db)
        {
            throw new NotImplementedException();
        }

        public override void showLichSuGiaoDichNapTienTable(DataGridView db)
        {
            throw new NotImplementedException();
        }

        public override void showLichSuGiaoDichTable(DataGridView db)
        {
            db.DataSource = _db.select_lichsugiaodich_gs(1);
        }

        public override void showLopMoiTable(DataGridView db)
        {
            db.DataSource = _db.DANHSACHMOLOPs.Select(p => p);
        }
    }
}
