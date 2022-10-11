using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD
        //tYPE Name();
        List<T> List();

        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T,bool>>filter);
    }
}
