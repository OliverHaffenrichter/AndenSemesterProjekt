using AndenSemesterProjekt.EFDbContext;
using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Services
{
    public class DbService
    {
        public async Task<List<Post>> GetPosts()
        {
            using (var context = new MwDbContext())
            {
                return await context.Posts.ToListAsync();
            }
        }

        public async Task AddPost(Post post)
        {
            using (var context = new MwDbContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public async Task DeletePost(Post post)
        {
            using (var context = new MwDbContext())
            {
                context.Remove(post);
                context.SaveChanges();
            }
        }

        public async Task UpdatePost(int id, Post post)
        {
            using (var context = new MwDbContext())
            {
                var std = context.Posts.First(p => p.Id == id);
                std.Title = post.Title;
                std.Information = post.Information;
                //std.CreationDate = post.CreationDate;
                context.SaveChanges();
            }
        }

        public void SavePosts(List<Post> posts)
        {
            using (var context = new MwDbContext())
            {
                foreach (Post post in posts)
                {
                    Console.WriteLine(post.Id);
                    context.Posts.Add(post);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
