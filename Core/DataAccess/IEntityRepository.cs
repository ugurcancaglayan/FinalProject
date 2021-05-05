using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess      //CORE EVRENSEL KATMANDIR! CORE katmanı diğer katmanları referans almaz. Diğer projelerde kullanabilmek için önemli!
{
    //generic constraint - kısıt
    //class : referans tip olabilir demek class olabilir demek değil
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //Bir class'a IEntity dediğimizde o class veritabanı tablosu görevi görür 
    //new() : new'lenebilir olmalı. interface newlenemez!
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
