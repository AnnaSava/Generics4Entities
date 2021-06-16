using Generics4Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics4Entities
{
    public abstract class BaseEntity : IEntity<int>
    {
        public int Id { get; set; }
    }

    public abstract class BaseUpdatableEntity : BaseEntity, IUpdatable
    {
        public DateTime LastUpdated { get; set; }
    }

    public abstract class BaseRestorableEntity : BaseUpdatableEntity, IRestorable
    {
        public bool IsDeleted { get; set; }
    }

    public abstract class BaseNamedEntity : BaseEntity, INamed
    {
        public string Name { get; set; }
    }

    public abstract class BaseUpdatableNamedEntity : BaseNamedEntity, IUpdatable, INamed
    {
        public DateTime LastUpdated { get; set; }
    }

    public abstract class BaseNamedUpdatableEntity : BaseUpdatableEntity, IUpdatable, INamed
    {
        public string Name { get; set; }
    }

    public abstract class BaseRestorableNamedEntity : BaseNamedEntity, IRestorable, INamed
    {
        public DateTime LastUpdated { get; set; }

        public bool IsDeleted { get; set; }
    }

    public abstract class BaseNamedRestorableEntity : BaseRestorableEntity, IRestorable, INamed
    {
        public string Name { get; set; }
    }
}
