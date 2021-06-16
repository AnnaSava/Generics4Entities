using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceNE<T> : CrudServiceE<T>
        where T : BaseNamedEntity
    {
        // дубль с CrudServiceRNE<T>, нельзя сделать общий базовый класс
        public T GetOneByName(string name)
        {
            return _repo.FirstOrDefault(m => m.Name == name);
        }
    }
}
