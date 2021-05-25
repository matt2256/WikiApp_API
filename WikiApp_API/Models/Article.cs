﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WikiApp_API.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }

        //Foreign key relations
        public int StandardId { get; set; }
        public Quiz Quiz { get; set; }


    }
}
