using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaSu.src.models;
using QuanLyGiaSu.src.database.database_local;

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
