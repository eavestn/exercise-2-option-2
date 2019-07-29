using Shuttle.Esb;
using StudentManagement.Esb.Messages.Commands;
using StudentManagement.Esb.Messages.Events;

namespace StudentManagementEsb.Handlers
{
    public class CreateStudentDataHandler : IMessageHandler<CreateStudentData>
    {
        public void ProcessMessage(IHandlerContext<CreateStudentData> context)
        {
            var data = context.Message;

            // In a more "real" ESB, we would use this layer to perform more sophisticated
            // translations between a received event and an event published to the larger
            // system. For the sake of brevity, I have not "converted" all the fields received
            // from the event.
            context.Publish(
                new NewStudentData()
                {
                    StudentId           = data.StudentId,
                    Name                = data.Name,
                    HomePhone           = data.HomePhone,
                    HomeAddress         = data.HomeAddress,
                    LocalAddress        = data.LocalAddress,
                    EmailAddress        = data.EmailAddress,
                    EmergencyContact    = data.EmergencyContact,
                    AcademicStatus      = data.AcademicStatus,
                    // ...
                }
           );
        }
    }
}
