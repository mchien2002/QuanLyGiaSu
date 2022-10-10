using QuanLyGiaSu.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using QuanLyGiaSu.database.database_local;
using QuanLyGiaSu.src.models;

namespace QuanLyGiaSu.src.controller
{
    abstract class BaseController
    {
        public TRUNGTAMGIASUDataContext _db;
        public abstract void showBangTinTable(DataGridView db);
        public abstract void showLopMoiTable(DataGridView db);
        public abstract void showLichSuGiaoDichTable(DataGridView db);
        public abstract void showLichSuGiaoDichNapTienTable(DataGridView db);
        public abstract void registerAccount(AccountModel account);

        public string hashPassWord(string pass, string userName)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(pass + userName);
            var hashPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashPassword);
        }
    }
}
