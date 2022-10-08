using QuanLyGiaSu.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.controller
{
    abstract class BaseController
    {
        public TRUNGTAMGIASUDataContext _db;
        public abstract void showBangTinTable(DataGridView db);
        public abstract void showLopMoiTable(DataGridView db);
        public abstract void showLichSuGiaoDichTable(DataGridView db);
        public abstract void showLichSuGiaoDichNapTienTable(DataGridView db);
    }
}
