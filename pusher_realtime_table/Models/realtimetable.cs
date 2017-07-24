using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pusher_realtime_table.Models
{
    public class realtimetable
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(225)]
        public string title { get; set; }
        [Required]
        public int year { get; set;  } 

    }
}