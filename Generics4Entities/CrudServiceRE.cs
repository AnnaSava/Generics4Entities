using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceRE<T> where T : BaseRestorableEntity
    {
        protected List<T> _repo = new List<T>();

        // дубль с CrudServiceE<T>, можно вынести в базовый класс
        public T Create(T model)
        {
            _repo.Add(model);
            return model;
        }

        // разное поведение с CrudServiceE<T> 
        public T Delete(int id)
        {
            var model = GetOne(id);
            model.IsDeleted = true;
            return model;
        }

        // отсутствует в CrudServiceE<T> 
        public T Restore(int id)
        {
            var model = GetOne(id);
            model.IsDeleted = false;
            return model;
        }

        // дубль с CrudServiceE<T>, можно вынести в базовый класс 
        public T GetOne(int id)
        {
            return _repo.FirstOrDefault(m => m.Id == id);
        }

        // дубль с CrudServiceE<T>, можно вынести в базовый класс 
        public IEnumerable<T> GetMany()
        {
            return _repo;
        }
    }
}
