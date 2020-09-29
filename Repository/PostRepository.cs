using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Web;
using TestProjectMVC.Helpers;
using TestProjectMVC.Models;

namespace TestProjectMVC.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {        public async Task<Post> GetPostById(int id)
        {
            using (var resposne = await HttpHelper.httpClient.GetAsync($"posts/{id}"))
            {
                if (resposne.IsSuccessStatusCode)
                {
                    var post = JsonConvert.DeserializeObject<Post>(await resposne.Content.ReadAsStringAsync());
                    return post;
                }
                else
                {
                    throw new Exception("did not go through");
                }
            }
        }
    }
}