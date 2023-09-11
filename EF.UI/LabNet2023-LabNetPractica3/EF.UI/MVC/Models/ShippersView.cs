using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ShippersView
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="El Telefono es obligatorio")]
        [Display(Name ="Phone:")]
        public string Phone {  get; set; }
        public string CompanyName { get; set; }
    }
}