using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialmMedia.Models
{
    public class FollowerModel
    {
        public int Id { get; set; } // Primary key
        public int UserId { get; set; }
        public int FollowerId { get; set; }
    }
}