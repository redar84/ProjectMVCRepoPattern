using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using TestProjectMVC.Helpers;

namespace TestProjectMVC.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAllPosts(string url)
        {
            using (var response = await HttpHelper.httpClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string strPosts = await response.Content.ReadAsStringAsync();
                    var entity = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(strPosts);
                    return entity;

                }
                else
                {
                    throw new Exception("not went well");
                }

            }
        }
    }
}