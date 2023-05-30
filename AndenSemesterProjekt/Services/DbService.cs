using AndenSemesterProjekt.EFDbContext;
using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Services
{
    public class DbService<T> where T : class
    {
        /// <summary>
        /// method used to get every object from the database 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new MwDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        /// <summary>
        /// method used to add an object to the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task AddObjectAsync(T obj)
        {
            using (var context = new MwDbContext())
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method used to delete an object from the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new MwDbContext())
            {
                context.Set<T>().Remove(obj);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// method used to udpate an object in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new MwDbContext())
            {
                context.Set<T>().Update(obj);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// method used for saving the changes done entity framework
        /// </summary>
        /// <param name="objs"></param>
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
