using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectMVC.Models;

namespace TestProjectMVC.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<Post> GetPostById(int id);
    }
}
