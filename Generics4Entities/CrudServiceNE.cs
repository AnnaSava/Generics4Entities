using Generics4Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceNE<T> : CrudServiceE<T>, ICrudServiceNamed<T>
        where T : BaseNamedEntity
    {
        // дубль с CrudServiceRNE<T>, нельзя сделать общий базовый класс
        public T GetOneByName(string name) => new GetOneByNameAction<T>(_repo).Execute(name);
    }
}
