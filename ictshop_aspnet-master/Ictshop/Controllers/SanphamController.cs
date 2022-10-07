using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult dtiphonepartial()
        {
            var ip = db.Sanphams.Where(n => n.Mahang==2).Take(4).ToList();
            return PartialView(ip);
        }
        public ActionResult dtsamsungpartial()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            return PartialView(ss);
        }
        public ActionResult dtxiaomipartial()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            return PartialView(mi);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key">Key là từ khóa tìm kiếm</param>
        /// <returns></returns>
        public ActionResult Search(string key = "")
        {
            /*var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();*/
            ViewBag.Key = key;
            var listSearch = db.Sanphams.Where(sp => sp.Tensp.Contains(key) == true).ToList();
            return View(listSearch);
        }


        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }
        public ActionResult sanpham_home()
        {
            var sp = db.Sanphams.OrderBy(Sp => Sp.Tensp).ToList();
            return PartialView(sp);
        }
        public ActionResult dtchung()
        {
            return View();
        }
    }

}