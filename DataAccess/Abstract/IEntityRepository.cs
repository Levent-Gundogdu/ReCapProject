using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Backend yazarken kurallar olusturulmalidir.
    //Generic Constraint : Generic Kisit
    //class : Referans tip 
    //new(): new'lenebilir olmali
    public interface IEntityRepository<T> where T : class, IEntity, new() 
    {
        //IEntity eklemek demek: T ya IEntity olabilir ya da IEntity'den implemente eden bir nesne olabilir demektir.
        //Merkez
        List<T> GetAll(Expression<Func<T,bool>>filter = null);  //Expression filtre vermeye yarar. 
        //Filter = null demek filtre vermeyebilirsin demektir.
        T Get(Expression<Func<T, bool>> filter);  //Burasi tek bir detaya gitmek icin kullanilir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
