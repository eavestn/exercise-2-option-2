
using Shuttle.Core.ServiceHost;
using Shuttle.Core.StructureMap;
using Shuttle.Esb;
using StructureMap;

namespace StudentManagement.Esb.ServiceProvider.CourseRegistrar
{
    public class ServiceProvider : IServiceHostStart
    {
        public IServiceBus _serviceBus;

        public void Start()
        {
            var structureMapRegistry = new Registry();
            var structureMapComponentRegistry = new StructureMapComponentRegistry(structureMapRegistry);

            Shuttle.Esb.ServiceBus.Register(structureMapComponentRegistry);

            var resolver = new StructureMapComponentResolver(new Container(structureMapRegistry));


            this._serviceBus = Shuttle.Esb.ServiceBus.Create(resolver).Start();
        }
        
        public void Stop()
        {
            this._serviceBus.Dispose();
        }
    }
}
