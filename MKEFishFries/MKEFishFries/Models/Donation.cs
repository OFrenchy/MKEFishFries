﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MKEFishFries.Models
{
    public class Donation
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }


        [ForeignKey("People")]
        public int PersonId { get; set; }
        public People People { get; set; }
    }
}