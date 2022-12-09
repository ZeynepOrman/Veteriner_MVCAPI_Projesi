using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Veteriner_MVC2.Models;

namespace Veteriner_MVC2.Controllers
{
    public class MVCHizmetlerController : Controller
    {
        // GET: Hizmetler
        public ActionResult Index()
        {
            IEnumerable<MVCHizmetlerModel> calList;
            HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Hizmet").Result; //apideli controllerımın adı. Bunu yanlış yazarsak hata alırız.
            calList = response.Content.ReadAsAsync<IEnumerable<MVCHizmetlerModel>>().Result;
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
                HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Hizmet/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCHizmetlerModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult Ekle(MVCHizmetlerModel hizmet) //crup
        {

            if (hizmet.HizmetNo == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PostAsJsonAsync("Veteriner_Hizmet", hizmet).Result;
                TempData["SuccessMessage"] = "başarılı şekilde eklendi";
            }

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PutAsJsonAsync("Veteriner_Hizmet/" + hizmet.HizmetNo, hizmet).Result;
                TempData["SuccessMessage"] = "başarılı şekilde güncellendi";

            }

            return RedirectToAction("Index");

        }

        public ActionResult Sil(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApClient.DeleteAsync("Veteriner_Hizmet/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "başarılı şekilde silindi";
            return RedirectToAction("Index");
        }

    }
}
