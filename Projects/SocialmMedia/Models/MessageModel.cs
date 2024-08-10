using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialmMedia.Models
{
    public class MessageModel
    {
        public int Id { set; get; }
        public int SenderId { set; get; }
        public int ReceiverId { set; get; }
        public string? Content { get; set; }

    }
}