﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheBlogProject.Models
{
    public class Blog
    {
        public int Id { get; set; } 
        public string BlogUserId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength =2)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }

        [Display(Name = "Blog Image")]
        public byte[] ImageData { get; set;  }

        [Display(Name = "Image Type")]
        public string ContentType { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        //navigation property
        [Display(Name ="Author")]
        public virtual BlogUser BlogUser { get; set; }
        public virtual ICollection<Post> Post { get; set; } = new HashSet<Post>();


    }
}
