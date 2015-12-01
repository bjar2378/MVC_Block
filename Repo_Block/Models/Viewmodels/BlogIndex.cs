using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo_Block.Models.Base_Models;

namespace Repo_Block.Models.Viewmodels
{
    public class BlogIndex
    {
        public Post Post { get; set; }
        public List<Billede> Billeder { get; set; }
    }
}
