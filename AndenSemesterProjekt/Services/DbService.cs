using AndenSemesterProjekt.EFDbContext;
using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Services
{
    public class DbService<T> where T : class
    {
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new MwDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task AddObjectAsync(T obj)
        {
            using (var context = new MwDbContext())
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
            }
        }

        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new MwDbContext())
            {
                context.Set<T>().Remove(obj);
                context.SaveChanges();
            }
        }

        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new MwDbContext())
            {
                context.Set<T>().Update(obj);
                context.SaveChanges();
            }
        }

        public void SaveObjectsAsync(List<T> objs)
        {
            using (var context = new MwDbContext())
            {
                foreach (T obj in objs)
                {
                    context.Set<T>().Add(obj);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
