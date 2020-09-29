using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestProjectMVC.Models;

namespace TestProjectMVC.Repository
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IEnumerable<Comment>> Find(Func<Comment, bool> predicate);
        //Task<IEnumerable<Comment>> Find(int id, string url);
    }
}
