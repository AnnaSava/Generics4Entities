using System;
using System.Collections.Generic;
using System.Text;

namespace Generics4Entities
{
    public class YourRNEService : CrudServiceRNE<YourNamedRestorableEntity>
    {
        public YourNamedRestorableEntity UpdateDescription(int id, string value)
        {
            var model = GetOne(id);
            model.DescriptionD2 = value;
            return model;
        }
    }
}
