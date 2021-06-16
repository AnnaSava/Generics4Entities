using Generics4Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics4Entities
{
    public class CrudServiceRE<T> : CrudServiceE<T>, ICrudServiceRestorable<T>
        where T : BaseRestorableEntity
    {
        // разное поведение с CrudServiceE<T> 
        public override T Delete(int id) => new DeleteAction<T>(_repo).Execute(id);

        public T Restore(int id) => new RestoreAction<T>(_repo).Execute(id);
    }
}
