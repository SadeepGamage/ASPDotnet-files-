using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace Blog.Models
{
    public class UserModel : IdentityUser
    {
        [Key]
        public int UserId { set; get; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Bio { get; set; }
        // post ,  Comment , follower
        public ICollection<PostModel> Posts { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
        // public ICollection<FollowerModel>Followers{ get; set; }
        // public ICollection<FollowerModel>Following{ get; set; }


    }
}

        