using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
        //veri tabına ekleme silme güncelleme(CRUD işlemleri) bunları base class oluşturduk orada hallettik 
    }
}
