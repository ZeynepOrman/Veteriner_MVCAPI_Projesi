using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Veteriner_MVC2.Models
{
    public class MVCSubelerModel
    {

        public int SubeNo { get; set; }
        [Required(ErrorMessage = "ad soyad girilmesi zorunludur")]
        public string SubeAdi { get; set; }

        public int CalisanSayisi { get; set; }

        public int? HizmetSayisi { get; set; }

    }
}