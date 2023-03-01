using System;
using System.Collections.Generic;

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
        public string Id { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

    public class A : Entity
    {
    }

    public class Foo : Entity
    {
    }

    public class FooRepository : IRepository<Foo>,
                                 IUnitOfWork
    {
        private const string FILE_NAME = "foos.txt";
        private readonly Dictionary<string, Foo> _items = new Dictionary<string, Foo>();

        public Foo Create()
        {
            var foo = new Foo();
            _items.Add(foo.Id, foo);
            return foo;
        }

        public void Delete(string id)
        {
            _items.Remove(id);
        }

        public bool Exists(string id)
        {
            return _items.ContainsKey(id);
        }

        public Foo Load(string id)
        {
            if (_items.TryGetValue(id, out Foo foo))
                return foo;
            else
                return null;
        }

        public void SaveChanges()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            var content = System.Text.Json.JsonSerializer.Serialize(_items.Values);
            System.IO.File.WriteAllText(fullPath, content);
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