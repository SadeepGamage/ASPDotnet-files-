using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class PostTagModel
    {
        [Key]
        public int PostId{ get; set; }
        public PostModel Post { get; set; }
        public int TagId { get; set; }
        public TagModel Tag { get; set;   }
    }
}