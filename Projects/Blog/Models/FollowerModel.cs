// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace Blog.Models
// {
//     public class FollowerModel
//     {
//         [Key]
//         public int FollowerId { get; set; }
//         public int UserId { get; set; }
//         [ForeignKey("UserId")]
//         public UserModel User { set; get; }
//         public int FollowingId { get; set; }

//         // [ForeignKey("FollowingId")]
//         // public UserModel User { get; set; }  // Navigation property for the follower
//         // public UserModel FollowingUser { get; set; }   
//     }
// }