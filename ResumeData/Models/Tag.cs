﻿using System.ComponentModel.DataAnnotations;

namespace ResumeData.Models
{
    public class Tag
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TagName { get; set; }
    }
}
