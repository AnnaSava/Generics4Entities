using Generics4Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceE<T> : ICrudServiceBase<T>
        where T : BaseEntity
    {
        protected List<T> _repo = new List<T>();

        // дубль с CrudServiceRE<T>, можно вынести в базовый класс
        public T Create(T model) => new CreateAction<T>(_repo).Execute(model);

        // разное поведение с CrudServiceE<T> 
        public virtual T Delete(int id)
        {
            var model = GetOne(id);
            _repo.Remove(model);
            return model;
        }

        // дубль с CrudServiceRE<T>, можно вынести в базовый класс
        public T GetOne(int id) => new GetOneAction<T>(_repo).Execute(id);

        // дубль с CrudServiceRE<T>, можно вынести в базовый класс
        public IEnumerable<T> GetMany() => new GetManyAction<T>(_repo).Execute();
    }
}
