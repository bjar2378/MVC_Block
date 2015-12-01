using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo_Block.Models.Base_Models;
using Repo_Block.Models.Viewmodels;
namespace Repo_Block
{
   public class PostFac : AutoFac <Post>
    {
        BilledeFac bf = new BilledeFac();
        public List<BlogIndex> GetIndexData()
        {
            List<BlogIndex> listBlockIndex = new List<BlogIndex>();
            foreach(var post in GetAll())
            {
                BlogIndex bi = new BlogIndex();
                bi.Post = post;
                bi.Billeder = bf.GetBy("PostID", post.ID);
                listBlockIndex.Add(bi);
            }
            return listBlockIndex;
        }
    }
}
