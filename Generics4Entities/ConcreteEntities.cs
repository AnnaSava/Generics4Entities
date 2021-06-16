using System;
using System.Collections.Generic;
using System.Text;

namespace Generics4Entities
{
    public class MyEntity : BaseEntity
    {
        public string DescriptionA { get; set; }
    }

    public class MyRestorableEntity : BaseRestorableEntity
    {
        public string DescriptionB { get; set; }
    }

    public class MyNamedEntity : BaseNamedEntity
    {
        public string DescriptionC { get; set; }
    }

    public class MyNamedRestorableEntity : BaseNamedRestorableEntity
    {
        public string DescriptionD { get; set; }
    }

    public class YourNamedRestorableEntity : BaseNamedRestorableEntity
    {
        public string DescriptionD2 { get; set; }
    }
}
