using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProjectMVC.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            Posts = new PostRepository();
            Comments = new CommentRepository();
        }
        public IPostRepository Posts { get; private set; }

        public ICommentRepository Comments { get; private set; }

        public void Dispose()
        {
             
        }
    }
}