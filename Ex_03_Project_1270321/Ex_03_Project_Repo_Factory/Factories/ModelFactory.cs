using Ex_03_Project_Repo_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Project_Repo_Factory.Factories
{
    public interface IModelFactory
    {
        T Create<T>(params object[] args) where T : class, IModelBase, new();
    }
    public class ModelFactory : IModelFactory
    {
        public T Create<T>(params object[] args) where T : class, IModelBase, new()
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }

    }
}
