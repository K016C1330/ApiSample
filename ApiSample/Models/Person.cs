using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiSample.Models
{

    public class Person
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "名前")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "メッセージ")]
        public string Message { get; set; }

    }
}