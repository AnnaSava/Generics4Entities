using System;

namespace Generics4Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myEServ = new CrudServiceE<MyEntity>();
            var myReServ = new CrudServiceRE<MyRestorableEntity>();
            var myNeServ = new CrudServiceNE<MyNamedEntity>();
            var myRneServ = new CrudServiceRNE<MyNamedRestorableEntity>();

            var yourRneServ = new YourRNEService();
        }
    }
}
