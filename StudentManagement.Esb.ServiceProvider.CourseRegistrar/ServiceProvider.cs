using Shuttle.Esb.Sql.Subscription;
using Shuttle.Core.ServiceHost;
using Shuttle.Core.StructureMap;
using Shuttle.Esb;
using StructureMap;
using StudentManagement.Esb.Messages.Events;

// For some reason, this .Container requirement is essential to the proper functioning 
// of the below Resolve<T>.Subscribe<G> method chain; it appears to function as an extension
// that is compile-time aware of the interface exposed by the resolution.
using Shuttle.Core.Container;

namespace StudentManagement.Esb.ServiceProvider.CourseRegistrar
{
    public class ServiceProvider : IServiceHostStart
    {
        public IServiceBus _serviceBus;

        public void Start()
        {
            var structureMapRegistry = new Registry();
            var structureMapComponentRegistry = new StructureMapComponentRegistry(structureMapRegistry);

            ServiceBus.Register(structureMapComponentRegistry);

            var resolver = new StructureMapComponentResolver(
                new Container(structureMapRegistry)
            );

            resolver.Resolve<ISubscriptionManager>().Subscribe<NewStudentData>();

            this._serviceBus = ServiceBus.Create(resolver).Start();
        }
        
        public void Stop()
        {
            this._serviceBus.Dispose();
        }
    }
}
