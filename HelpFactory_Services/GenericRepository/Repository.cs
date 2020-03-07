using HelpFactory.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
       private   HelpFactory_Context _Context;/*HelpFactory_Context  _Context = new HelpFactory_Context(); bh Kr Skty Hai But
        But In Generic Repositary Pattern Hum Object Initilization Constructor Ma Krty Hai !

        /*Project Ki DatabaseContext Class Ka Reference Create Krna Hai Yha Pa or By
        _context E Rkhna Hai, Moslty Videos Ma bh isi Trha Apply Hota Hai*/

        private IDbSet<T> dbEntity;
        public Repository()
        {
            _Context = new HelpFactory_Context();//Entity Class K Controller Ki Request Recieve Krny K Lye.. 
            dbEntity = _Context.Set<T>();// Entity Class K Controller Ki Request K Against DB sy Interact Krny k Lye..
        }

        public void Delete(object Id)
        {
            T getObjById = dbEntity.Find(Id);
            dbEntity.Remove(getObjById);
        }

        public IEnumerable<T> GetAll()
        {
            return dbEntity.ToList();
        }

        public T GetById(object Id)
        {
            return dbEntity.Find(Id);

        }

        public void  Insert(T obj)
        {
            dbEntity.Add(obj);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Update(T obj)
        {
            _Context.Entry(obj).State = EntityState.Modified;
        }
    }
}
