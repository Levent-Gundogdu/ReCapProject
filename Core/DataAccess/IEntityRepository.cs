using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//Core katmani diger katmanlari referans almaz!
namespace Core.DataAccess //class ve interface'leri kolay ulasmak icin namespace'e koyariz
{
    //Generic Repository Design Pattern

    //Backend yazarken kurallar olusturulmalidir.
    //Generic Constraint : Generic Kısıt
    //T : class demek T referans tip olabilir demek.
    //new(): new'lenebilir olmali demektir.
    //IEntity eklemek demek: T ya IEntity olabilir ya da IEntity'den implemente eden bir nesne olabilir demektir.
    //Merkez
    public interface IEntityRepository<T> where T : class, IEntity, new() //Şartlar buraya yazılır.
    {
        
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //Expression filtre vermeye yarar.
        //Filter = null demek filtre vermeyebilirsin demektir.
        T Get(Expression<Func<T, bool>> filter);  //Burasi tek bir detaya gitmek icin kullanilir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
