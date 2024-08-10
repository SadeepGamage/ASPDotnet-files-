using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogapi.Data;
namespace Blogapi.Models
{
    public class PostModel
    {
        int Id { set; get; }
        string? Title { set; get; }
        string? Description { set; get; }

    }
}