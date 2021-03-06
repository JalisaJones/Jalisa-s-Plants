﻿using Plant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant.Models
{
   public class CartDetail
    {
        [Key]
        public int CartId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public int PlantId { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public virtual PlantItem Plants { get; set; }

    }
        
}
