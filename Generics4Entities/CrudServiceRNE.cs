using Generics4Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceRNE<T> : CrudServiceRE<T>, ICrudServiceNamed<T>
        where T : BaseNamedRestorableEntity
    {
        // дубль с CrudServiceNE<T>, нельзя сделать общий базовый класс
        public T GetOneByName(string name) => new GetOneByNameAction<T>(_repo).Execute(name);
    }
}
