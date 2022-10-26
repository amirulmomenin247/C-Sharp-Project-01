using Ex_03_Project_Repo_Factory.Models;
using Ex_03_Project_Repo_Factory.Repoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Project_Repo_Factory.Factories
{
    public interface IRepoFactory
    {
        IGenericRepo<T> Create<T>() where T : class, IModelBase, new();
    }
    public class RepoFactory : IRepoFactory
    {
        public IGenericRepo<T> Create<T>() where T : class, IModelBase, new()
        {
            return Activator.CreateInstance(typeof(GenericRepo<T>),
            new object[] { new List<T>() }) as GenericRepo<T>;
        }
    }
}
