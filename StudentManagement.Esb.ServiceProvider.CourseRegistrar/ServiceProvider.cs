using Shuttle.Core.ServiceHost;
using Shuttle.Esb;

namespace StudentManagement.Esb.ServiceProvider.CourseRegistrar
{
    public class ServiceProvider : IServiceHostStart
    {
        public IServiceBus _serviceBus;

        public void Start()
        {

        }
        
        public void Stop()
        {
            this._serviceBus.Dispose();
        }
    }
}
