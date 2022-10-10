using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.database.database_local;
using QuanLyGiaSu.src.models;
using QuanLyGiaSu.src.server;
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

        public override void fetchBangTinTable(DataGridView dgv)
        {
            throw new NotImplementedException();
        }

        public override void fetchLichSuGiaoDichNapTienTable(DataGridView db)
        {
            throw new NotImplementedException();
        }

        public override void fetchLichSuGiaoDichTable(DataGridView db)
        {
            db.DataSource = _db.select_lichsugiaodich_gs(1);
        }

        public override void fetchLopMoiTable(DataGridView db)
        {
            db.DataSource = Locator.server.fetchLopMoiTable();
        }
    }
}
