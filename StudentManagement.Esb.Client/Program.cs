using Shuttle.Core.StructureMap;
using Shuttle.Esb;
using StructureMap;
using StudentManagement.Esb.Clieant.Services;

namespace StudentManagement.Esb.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var smRegistry = new Registry();

            ServiceBus.Register(new StructureMapComponentRegistry(smRegistry));
            
            // We aren't doing anything with thie variable; but - theoretically - we could should we want 
            // to do some postprocessing prior to application exit.
            var registrar = 
                new StudentRegistrar(new StructureMapComponentResolver(new Container(smRegistry)))
                    .Start();
        }
    }
}

