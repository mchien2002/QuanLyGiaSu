using QuanLyGiaSu.src.controllers.Admin;
using QuanLyGiaSu.src.controllers.Parent;
using QuanLyGiaSu.src.controllers.Tutor;
using QuanLyGiaSu.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaSu.src.controller
{
    static class Locator
    {
        public static TutorController tutorController = new TutorController();
        public static AdminController adminController = new AdminController();
        public static ParentController parentController = new ParentController();
        public static AccountModel author = new AccountModel();
    }
}
