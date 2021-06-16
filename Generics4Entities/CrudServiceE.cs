using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceE<T> where T : BaseEntity
    {
        protected List<T> _repo = new List<T>();

        // дубль с CrudServiceRE<T>, можно вынести в базовый класс
        public T Create(T model)
        {
            _repo.Add(model);
            return model;
        }

        // разное поведение с CrudServiceE<T> 
        public T Delete(int id)
        {
            var model = GetOne(id);
            _repo.Remove(model);
            return model;
        }

        // дубль с CrudServiceRE<T>, можно вынести в базовый класс
        public T GetOne(int id)
        {
            return _repo.FirstOrDefault(m => m.Id == id);
        }

        // дубль с CrudServiceRE<T>, можно вынести в базовый класс
        public IEnumerable<T> GetMany()
        {
            return _repo;
        }
    }
}
