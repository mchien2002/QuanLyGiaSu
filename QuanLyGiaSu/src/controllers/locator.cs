using QuanLyGiaSu.src.models;
using QuanLyGiaSu.src.server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaSu.src.controller
{
    static class Locator
    {
        public static Server server = new Server();
        public static AccountModel author = new AccountModel();
        public static bool isOpenningNapTien = false;
        public static int LMID = 0;
    }

    public enum UserType
    {
        tutor,
        parent,
        admin
    }
}
