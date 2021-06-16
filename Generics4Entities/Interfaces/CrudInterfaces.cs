using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics4Entities.Interfaces
{
    public interface ICrudServiceBase<T> where T : BaseEntity
    {
        T Create(T model);

        T Delete(int id);

        T GetOne(int id);

        IEnumerable<T> GetMany();
    }

    public interface ICrudServiceUpdatable<T> where T : IUpdatable
    {
        T Update(T model);
    }

    public interface ICrudServiceNamed<T> where T: INamed
    {
        T GetOneByName(string name);
    }

    public interface ICrudServiceRestorable<T> where T: IRestorable
    {
        T Delete(int id);

        T Restore(int id);
    }
}
