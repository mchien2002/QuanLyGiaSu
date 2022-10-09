using QuanLyGiaSu.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace QuanLyGiaSu.src.controller
{
    abstract class BaseController
    {
        public TRUNGTAMGIASUDataContext _db;
        public abstract void showBangTinTable(DataGridView db);
        public abstract void showLopMoiTable(DataGridView db);
        public abstract void showLichSuGiaoDichTable(DataGridView db);
        public abstract void showLichSuGiaoDichNapTienTable(DataGridView db);
        public abstract void registerAccount(string userName, string passWord, string confirmPassWord);

        public string hashPassWord(string pass)
        {
            var bytes = new byte[128 / 8]; // divide by 8 to convert bits to bytes

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: pass,
                salt: bytes,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8)
            );

            return hashed;
        }
    }
}
