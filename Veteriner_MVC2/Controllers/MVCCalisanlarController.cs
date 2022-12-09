using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Veteriner_MVC2.Models;

namespace Veteriner_MVC2.Controllers
{
    public class MVCCalisanlarController : Controller
    {
        // GET: Calisanlar
        public ActionResult Index()
        {
            IEnumerable<MVCCalisanlarModel> calList;
            HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Calisan").Result; //apideli controllerımın adı. Bunu yanlış yazarsak hata alırız.
            calList = response.Content.ReadAsAsync<IEnumerable<MVCCalisanlarModel>>().Result;
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
                HttpResponseMessage response = GlobalVariables.WebApClient.GetAsync("Veteriner_Calisan/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCCalisanlarModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult Ekle(MVCCalisanlarModel calisan) //crup
        {

            if (calisan.CalisanNo == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PostAsJsonAsync("Veteriner_Calisan", calisan).Result;
                TempData["SuccessMessage"] = "başarılı şekilde eklendi";
            }

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApClient.PutAsJsonAsync("Veteriner_Calisan/" + calisan.CalisanNo, calisan).Result;
                TempData["SuccessMessage"] = "başarılı şekilde güncellendi";

            }

            return RedirectToAction("Index");

        }

        public ActionResult Sil(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApClient.DeleteAsync("Veteriner_Calisan/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "başarılı şekilde silindi";
            return RedirectToAction("Index");
        }

    }
}
