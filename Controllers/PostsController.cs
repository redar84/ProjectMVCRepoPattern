using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TestProjectMVC.Helpers;
using TestProjectMVC.Models;
using TestProjectMVC.Repository;
using TestProjectMVC.ViewModel;

namespace TestProjectMVC.Controllers
{
    [Route("[controller]")]
    public class PostsController : Controller
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();
        public async Task<ActionResult> GetAllPosts()
        {
            
            string url = "posts";
            var posts = await unitOfWork.Posts.GetAllPosts(url);
            return View(posts);
            
        }

        public async Task<ActionResult> GetPostById(int id)
        {
          
            var post = await unitOfWork.Posts.GetPostById(id);
            return View(post);
        }

        public async Task<ActionResult> GetPostAndComments(int id)
        {
            
          
            var postbycomment = (List<Comment>)await unitOfWork.Comments.Find(x=>x.postId == id);

            PostCommentViewModel res = new PostCommentViewModel()
            {
                Post = await unitOfWork.Posts.GetPostById(id),
                Comments = postbycomment
            };
            return View(res);
            
        }
    }
}