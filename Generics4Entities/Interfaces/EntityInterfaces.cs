using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics4Entities.Interfaces
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    public interface IUpdatable
    {
        public DateTime LastUpdated { get; set; }
    }

    public interface IRestorable : IUpdatable
    {
        public bool IsDeleted { get; set; }
    }

    public interface INamed
    {
        public string Name { get; set; }
    }
}
