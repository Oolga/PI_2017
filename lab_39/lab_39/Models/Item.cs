using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab_39.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(30)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(30)]
        public string Middlename { get; set; }
        [Required]
        public DateTime BDay { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }
    }
}