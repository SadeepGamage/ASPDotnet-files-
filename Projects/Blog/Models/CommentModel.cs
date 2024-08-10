using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; } 
        public int PostId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string? Content { get; set; } 

        public UserModel User { set; get; }
        public PostModel Post { get; set; }
    }
}