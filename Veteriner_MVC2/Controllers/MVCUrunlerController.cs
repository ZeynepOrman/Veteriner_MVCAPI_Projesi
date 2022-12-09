using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Veteriner_MVC2.Models;

namespace Veteriner_MVC2.Controllers
{
    public class MVCUrunlerController : Controller
    {
        // GET: Urunler
        public ActionResult Index()
        {
            IEnumerable<MVCUrunlerModel> calList;
            HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Urun").Result; //apideli controllerımın adı. Bunu yanlış yazarsak hata alırız.
            calList = response.Content.ReadAsAsync<IEnumerable<MVCUrunlerModel>>().Result;
            return View(calList);
        }

        public ActionResult Ekle(int id = 0) //crup
        {
            if (id == 0)

            {
                return View();

            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Urun/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCUrunlerModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult Ekle(MVCUrunlerModel urun) //crup
        {

            if (urun.UrunNo == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PostAsJsonAsync("Veteriner_Urun", urun).Result;
                TempData["SuccessMessage"] = "başarılı şekilde eklendi";
            }

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PutAsJsonAsync("Veteriner_Urun/" + urun.UrunNo, urun).Result;
                TempData["SuccessMessage"] = "başarılı şekilde güncellendi";

            }

            return RedirectToAction("Index");

        }

        public ActionResult Sil(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApClient.DeleteAsync("Veteriner_Urun/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "başarılı şekilde silindi";
            return RedirectToAction("Index");
        }

    }
}
