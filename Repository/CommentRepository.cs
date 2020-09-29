using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using TestProjectMVC.Helpers;
using TestProjectMVC.Models;

namespace TestProjectMVC.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {

        public async Task<IEnumerable<Comment>> Find(Func<Comment, bool> predicate)
        {
            using (var response = await HttpHelper.httpClient.GetAsync("comments"))
            {

                if (response.IsSuccessStatusCode)
                {
                     var str = await response.Content.ReadAsStringAsync();

                    //var jobj = JArray.Parse(await response.Content.ReadAsStringAsync());
                    //var result = jobj.Select(predicate)
                    var result = JsonConvert.DeserializeObject<List<Comment>>(str);
                    var finalResult = result.Where(predicate).ToList();
                 
                    return finalResult;
                   
                    //var comments = from c in json["postId"]

                }
                else
                {
                    throw new Exception("");
                }


            }

           
        }
    }
}