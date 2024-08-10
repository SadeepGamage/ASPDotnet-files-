using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class TagModel
    {
        [Key]
        public int TagId { get; set; }
        [Required]
        public string? Name { get; set; }
        public ICollection<PostTagModel>PostTags{ get; set; }
        
        
    }
}