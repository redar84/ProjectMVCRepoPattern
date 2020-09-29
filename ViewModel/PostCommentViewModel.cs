using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestProjectMVC.Models;

namespace TestProjectMVC.ViewModel
{
    public class PostCommentViewModel
    {
        public Post Post { get; set; }
        public List<Comment> Comments { get; set; }
    }
}