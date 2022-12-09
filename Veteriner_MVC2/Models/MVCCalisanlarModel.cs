using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veteriner_MVC2.Models
{
    public class MVCCalisanlarModel
    {
        public int CalisanNo { get; set; }
        [Required(ErrorMessage = "ad soyad girilmesi zorunludur")]
        public string CalisanAdi { get; set; }

        public int? Yas { get; set; }

        public string Telefon { get; set; }

        public string Mail { get; set; }

        public int SubeNo { get; set; }

    }
}

