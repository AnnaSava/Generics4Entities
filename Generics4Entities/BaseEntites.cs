using System;
using System.Collections.Generic;
using System.Text;

namespace Generics4Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    public abstract class BaseRestorableEntity : BaseEntity
    {
        public bool IsDeleted { get; set; }
    }

    public abstract class BaseNamedEntity : BaseEntity
    {
        public string Name { get; set; }
    }

    public abstract class BaseNamedRestorableEntity : BaseRestorableEntity
    {
        public string Name { get; set; }
    }
}
