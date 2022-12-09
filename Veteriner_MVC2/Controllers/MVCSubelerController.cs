using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Veteriner_MVC2.Models;

namespace Veteriner_MVC2.Controllers
{
    public class MVCSubelerController : Controller
    {
        // GET: Subeler
        public ActionResult Index()
        {
            IEnumerable<MVCSubelerModel> calList;
            HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Sube").Result; //apideli controllerımın adı. Bunu yanlış yazarsak hata alırız.
            calList = response.Content.ReadAsAsync<IEnumerable<MVCSubelerModel>>().Result;
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
                HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Sube/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCSubelerModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult Ekle(MVCSubelerModel sube) //crup
        {

            if (sube.SubeNo == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PostAsJsonAsync("Veteriner_Sube", sube).Result;
                TempData["SuccessMessage"] = "başarılı şekilde eklendi";
            }

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PutAsJsonAsync("Veteriner_Sube/" + sube.SubeNo, sube).Result;
                TempData["SuccessMessage"] = "başarılı şekilde güncellendi";

            }

            return RedirectToAction("Index");

        }

        public ActionResult Sil(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApClient.DeleteAsync("Veteriner_Sube/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "başarılı şekilde silindi";
            return RedirectToAction("Index");
        }

    }
}
