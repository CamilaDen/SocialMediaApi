using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            //Range simula un ciclo de 1 a 10 y lo utilizo para cargar y listar las propiedades
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://misapis.com/{x}",
                UserId = x * 2
            }) ;

            return posts;
        }
    }
}
