using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Veteriner_MVC2.Models
{
    public class MVCHizmetlerModel
    {
        public int HizmetNo { get; set; }
        [Required(ErrorMessage = "ad soyad girilmesi zorunludur")]
        public string HizmetAdi { get; set; }

        public string HizmetAmaci { get; set; }

        public int? Fiyat { get; set; }

        public int CalisanNo { get; set; }

    }
}