using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{   //core katmanları diger katmanları referans almaz**
    //generic constraint
    //T: class=> referans tip olmalı demektir
    //IEntity: IEntity olabilir ya da IEntitye implemente eden bir nesne de olabilir 
    //new() : newlnebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        // List<T> GetAllByCategory(int categoryId);
    }
}
