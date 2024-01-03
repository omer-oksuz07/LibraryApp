﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models
{
    public class Favorite
    {
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        [Required]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book? Book { get; set; } 
    }
}
