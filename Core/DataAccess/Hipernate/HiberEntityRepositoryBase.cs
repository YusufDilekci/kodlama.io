using Core.DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Hipernate
{
    public class HiberEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            Console.WriteLine("Veritabanına Eklendi");
        }

        public void Delete(TEntity entity)
        {
            Console.WriteLine("Veritabanından Silindi");
        }

        public List<TEntity> GetAll()
        {
            return new List<TEntity>();
        }

        public void Update(TEntity entity)
        {
            Console.WriteLine("Veritabanında Güncellendi");
        }
    }
}
