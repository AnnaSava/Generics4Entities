using Generics4Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics4Entities
{
    public class CreateAction<T> where T : BaseEntity
    {
        List<T> _repo;
        public CreateAction(List<T> repo)
        {
            _repo = repo;
        }

        public T Execute(T model)
        {
            _repo.Add(model);
            return model;
        }
    }

    public class UpdateAction<T> where T : BaseEntity, IUpdatable
    {
        List<T> _repo;
        public UpdateAction(List<T> repo)
        {
            _repo = repo;
        }

        public T Execute(T model)
        {
            model.LastUpdated = DateTime.Now;
            return model;
        }
    }

    public class DeleteAction<T> where T : BaseEntity, IRestorable
    {
        List<T> _repo;
        public DeleteAction(List<T> repo)
        {
            _repo = repo;
        }

        public T Execute(int id)
        {
            var model = new GetOneAction<T>(_repo).Execute(id);
            model.IsDeleted = true;
            model.LastUpdated = DateTime.Now;
            return model;
        }
    }

    public class RestoreAction<T> where T : BaseEntity, IRestorable
    {
        List<T> _repo;
        public RestoreAction(List<T> repo)
        {
            _repo = repo;
        }

        public T Execute(int id)
        {
            var model = new GetOneAction<T>(_repo).Execute(id);
            model.IsDeleted = true;
            model.LastUpdated = DateTime.Now;
            return model;
        }
    }

    public class GetOneAction<T> where T : BaseEntity
    {
        List<T> _repo;
        public GetOneAction(List<T> repo)
        {
            _repo = repo;
        }

        public T Execute(int id)
        {
            return _repo.FirstOrDefault(m => m.Id == id);
        }
    }

    public class GetManyAction<T> where T : BaseEntity
    {
        List<T> _repo;
        public GetManyAction(List<T> repo)
        {
            _repo = repo;
        }

        public IEnumerable<T> Execute()
        {
            return _repo;
        }
    }

    public class GetOneByNameAction<T> where T : INamed
    {
        List<T> _repo;
        public GetOneByNameAction(List<T> repo)
        {
            _repo = repo;
        }

        public T Execute(string name)
        {
            return _repo.FirstOrDefault(m => m.Name == name);
        }
    }
}
