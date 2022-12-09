using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Veteriner_MVC2.Models
{
    public class MVCUrunlerModel
    {
        public int UrunNo { get; set; }
        [Required(ErrorMessage = "ad soyad girilmesi zorunludur")]
        public string UrunAdi { get; set; }

        public int? UrunFiyat { get; set; }

        public string KullanimAmaci { get; set; }

        public int HizmetNo { get; set; }

    }
}