using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialmMedia.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public int UserId { set; get; }
        public string? Content { set; get; }
        public string? MediaUrl { set; get; }
    }

}