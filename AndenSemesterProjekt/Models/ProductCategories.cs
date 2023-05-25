﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndenSemesterProjekt.Models
{
    public class ProductCategories
    {
        [Required]
        [ForeignKey("Product")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Category { get; set; }

        public ProductCategories(string category)
        {
            Category = category;
        }

        public ProductCategories()
        {

        }
    }
}