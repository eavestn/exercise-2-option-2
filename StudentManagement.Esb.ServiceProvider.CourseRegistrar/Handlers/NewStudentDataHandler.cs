using Shuttle.Esb;
using StudentManagement.Esb.Messages.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Esb.ServiceProvider.CourseRegistrar.Handlers
{
    public class NewStudentDataHandler : IMessageHandler<NewStudentData>
    {
        public void ProcessMessage(IHandlerContext<NewStudentData> context)
        {
            // Here we could perform any necessary transforms to interact with the
            // course registration system in response to the event and raise any 
            // subsequent events to the system we felt necessary.
            Console.WriteLine();
            Console.WriteLine($"[MESSAGE RECEIVED] : email = {context.Message.EmailAddress}");
            Console.WriteLine();
        }
    }
}
