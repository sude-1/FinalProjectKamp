using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //entity framework(veri tabanına nesnelerimizi bağlar veri alış verişi yapar)
    //bu class ise bizim entitylerimiz için entityframework te yazdığımız ortak kodlar
    // bir tane entity tipi ve veri tabanı gönderip işlemlerimizi yaparız
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//referansı yakala
                addedEntity.State = EntityState.Added; //o eklenecek nesne
                context.SaveChanges();//değişiklikleri kaydet veri tabanı nesnemi oluşturduğuma 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);//referansı yakala
                deletedEntity.State = EntityState.Deleted; //o silinecek nesne
                context.SaveChanges();//değişiklikleri oluşturduğum veri tabanı nesneme kaydet
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                //bir tane ürün getirecek
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //filtre null mı diye bakıyoruz 
                //null ise ? kısmına bakar ve orayı çalıştırır
                // eğer değilse : kısmına bakar orayı çalıştırır

                return filter == null
                    ? context.Set<TEntity>().ToList() //veritabında select*from products ile aynı
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);//referansı yakala
                updatedEntity.State = EntityState.Modified; //o güncellenicek nesne
                context.SaveChanges();//değişiklikleri oluşturduğum veri tabanı nesneme kaydet
            }
        }
    }
}
