using System.Windows.Forms;
using QuanLyGiaSu.src.database;

namespace QuanLyGiaSu.src.controller
{
    abstract class BaseController
    {
        public TRUNGTAMGIASUDataContext _db;
        public abstract void fetchBangTinTable(DataGridView dgv);
        public abstract void fetchLopMoiTable(DataGridView dgv);
        public abstract void fetchLichSuGiaoDichTable(DataGridView dgv);
        public abstract void fetchLichSuGiaoDichNapTienTable(DataGridView dgv);
    }
}
