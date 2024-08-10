using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialmMedia.Models
{
    public class UserModel
    {
        public int Id { set; get; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { set; get; }
        public byte[]? strProfilePicture { set; get; }
        public string? Bio { set; get; }
        // Datetime CreatedAt { set; get; } make sure collect those CraetedAt time here later
    }

    // public UserModel()
    // {
    //     CreatedAt = DateTime.Now;
    // }
}