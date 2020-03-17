using HelpFactory.DataBase;
using HelpFactory_Entities;
using HelpFactory_Services.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services.Repository
//After implementing all interfaces it’s time to implement concrete repository classes. First, 
//I create a class Repository which inherits from IRepository. 
//In this class, I implement all methods from the interface. Additionally to the methods, 
//I have a constructor which takes a DbContext as Parameter. 
//This DbContext instantiates a DbSet which will be used to get or add data.
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
       // private DbSet<T> dbset;
        public Repository(DbContext context)
        {
            Context = context;
         //   dbset = context.Set<T>();
        }

        public void Delete(object Id)
        {
            T getObjById = Context.Set<T>().Find(Id);
            Context.Set<T>().Remove(getObjById);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T GetById(object Id)
        {
            return Context.Set<T>().Find(Id);
        }

        public void Insert(T obj)
        {
            Context.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
        }
    }
}
        //        private HelpFactory_Context _Context;

        //     /*HelpFactory_Context  _Context = new HelpFactory_Context(); bh Kr Skty Hai But
        //    But In Generic Repositary Pattern Hum Object Initilization Constructor Ma Krty Hai !

        ///*Project Ki DatabaseContext Class Ka Reference Create Krna Hai Yha Pa or By
        //_context E Rkhna Hai, Moslty Videos Ma bh isi Trha Apply Hota Hai*/

        //        private IDbSet<T> dbEntity;
        //        public Repository()
        //        {
        //            _Context = new HelpFactory_Context();//Entity Class K Controller Ki Request Recieve Krny K Lye.. 
        //            dbEntity = _Context.Set<T>();// Entity Class K Controller Ki Request K Against DB sy Interact Krny k Lye..
        //        }


        //        public void Delete(object Id)
        //        {
        //            T getObjById = dbEntity.Find(Id);
        //            dbEntity.Remove(getObjById);
        //        }

        //        public IEnumerable<T> GetAll()
        //        {
        //            return dbEntity.ToList();
        //        }

        //        public T GetById(object Id)
        //        {
        //            return dbEntity.Find(Id);

        //        }

        //        public void Insert(T obj)
        //        {
        //            dbEntity.Add(obj);
        //        }

        //        public void Save()
        //        {
        //            _Context.SaveChanges();
        //        }

        //        public void Update(T obj)
        //        {
        //            _Context.Entry(obj).State = EntityState.Modified;
        //        }
        //        // Unit Of Work Implementation
        //        //protected readonly DbContext db;
        //        //public Repository(DbContext _db)
        //        //{
        //        //    db = _db;
        //        //}
        //        //public IEnumerable GetAll()
        //        //{
        //        //    return db.Set().ToList();
        //        //}



        //        //public T Get(object Id)
        //        //{
        //        //    return db.Set().Find(Id);
        //        //}

        //        //public void Add(T entity)
        //        //{
        //        //    db.Set().Add(entity);
        //        //}

        //        //public void AddRange(IEnumerable entities)
        //        //{
        //        //    db.Set().AddRange(entities);
        //        //}

        //        //public void Remove(T entity)
        //        //{
        //        //    db.Set().Remove(entity);
        //        //}



        //        //public void Remove(object Id)
        //        //{
        //        //    TEntity entity = db.Set().Find(Id);
        //        //    this.Remove(entity);
        //        //}

        //        //public void Update(TEntity entity)
        //        //{
        //        //    db.Entry(entity).State = EntityState.Modified;
        //        //}

        //        //}
    

