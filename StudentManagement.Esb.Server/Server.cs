using Shuttle.Core.ServiceHost;
using Shuttle.Core.StructureMap;
using Shuttle.Esb;
using StructureMap;

namespace StudentManagement.Esb.Server
{
    public class Server : IServiceHost
    {
        private Shuttle.Esb.IServiceBus _serviceBus;

        public void Start()
        {
            // I am namespacing one-off uses of the Shuttle.* framework to make it readily
            // apparent at what stages I am interacting with classes made available from the 
            // use of the library.
            var structureMapRegistry = new StructureMap.Registry();
            var structureMapComponentRegistry = new Shuttle.Core.StructureMap.StructureMapComponentRegistry(structureMapRegistry);
            
            Shuttle.Esb.ServiceBus.Register(structureMapComponentRegistry);

            this._serviceBus = Shuttle.Esb.ServiceBus.Create(
                new StructureMapComponentResolver(
                    new Container(structureMapRegistry)
                )
            ).Start();
        }

        public void Stop()
        {
            this._serviceBus.Dispose();
        }
    }
}
