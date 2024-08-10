using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialmMedia.Models
{
    public class FriendRequestModel
    {
        public int Id { get; set; }
        public int ServerId {get; set; }
        public int ReceiverId { get; set; }
        public string? Status { get; set; }
        
    }
}