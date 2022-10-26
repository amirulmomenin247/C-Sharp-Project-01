using Ex_03_Project_Repo_Method.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Project_Repo_Method.Repoes
{
    public interface IGenericRepo<T> where T : class, IModelBase, new()
    {
        IList<T> Get();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
    public class GenericRepo<T> : IGenericRepo<T> where T : class, IModelBase, new()
    {
        IList<T> dbSet;
        public GenericRepo(IList<T> dbSet)
        {
            this.dbSet = dbSet;
        }
        public T Get(int id)
        {
            return this.dbSet.FirstOrDefault(x => x.Id == id);
        }
        public IList<T> Get()
        {
            return this.dbSet;
        }
        public void Add(T obj)
        {
            this.dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            var x = this.dbSet.FirstOrDefault(o => o.Id == obj.Id);
            if (x != null)
            {
                var i = this.dbSet.IndexOf(x);
                this.dbSet.RemoveAt(i);
                this.dbSet.Insert(i, obj);
            }
        }
        public void Delete(int id)
        {
            var x = this.dbSet.FirstOrDefault(o => o.Id == id);
            if (x != null)
            {
                var i = this.dbSet.IndexOf(x);
                this.dbSet.RemoveAt(i);
            }
        }


    }
    public interface IRepoCreator
    {

        IGenericRepo<T> GetRepo<T>() where T : class, IModelBase, new();
    }
    public class RepoCreator : IRepoCreator
    {
        public IGenericRepo<T> GetRepo<T>() where T : class, IModelBase, new()
        {
            return new GenericRepo<T>(new List<T>());
        }
    }
}
