using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class PostModel
    {
        [Key]
        public int PostId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public UserModel User { get; set; }
        // PostTagModel , Comments 

        public ICollection<PostTagModel>PostTags{ get; set; }
        public ICollection<CommentModel>Comments{ get; set; }
        

        
    }
}