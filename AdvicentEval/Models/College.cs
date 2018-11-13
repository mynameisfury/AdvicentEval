using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvicentEval.Models
{
    public class College
    {
        [Key]
        public int? ID { get; set; }
        public string CollegeName { get; set; }
        public int? InStateTuition { get; set; }
        public int? OutofStateTuition { get; set; }
        public int? RoomAndBoard { get; set; }

    }
}