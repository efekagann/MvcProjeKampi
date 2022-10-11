using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> categories;
        public void Delete(Category p)
        {
            categories.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            categories.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return categories.ToList();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
