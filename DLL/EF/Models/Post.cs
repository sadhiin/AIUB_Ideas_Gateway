﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.EF.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

        public bool IsBan { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
