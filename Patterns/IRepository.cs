using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Patterns
{
   
    public interface IUnitOfWork
    {
        void SaveChanges();

    }

    public interface IRepository<T>
        where T : Entity
    {
        T Create();
        T Load(string id);
        void Delete(string id);
        bool Exists(string id);
    }

    public class Entity
    {
        public string Id { get; set; }
    }
    public class  A:Entity
    { 
    }
    public class Foo :Entity
    { 
    }


    public class FooRepository : IRepository<Foo>, 
                                 IUnitOfWork
    {
        public Foo Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string id)
        {
            throw new NotImplementedException();
        }

        public Foo Load(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class ARepository : IRepository<A>
    {
        public A Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string id)
        {
            throw new NotImplementedException();
        }

        public A Load(string id)
        {
            throw new NotImplementedException();
        }
    }
}
