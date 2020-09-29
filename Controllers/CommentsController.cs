using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestProjectMVC.Repository;

namespace TestProjectMVC.Controllers
{
    public class CommentsController : Controller
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Comments
        public async Task<ActionResult> GetAllComments()
        {
            string url = "comments";
            var comments = await unitOfWork.Comments.GetAllPosts(url);
            return View(comments);
        }
    }
}