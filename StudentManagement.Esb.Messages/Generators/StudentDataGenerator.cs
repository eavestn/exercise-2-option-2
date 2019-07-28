using StudentManagement.Esb.Messages.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Esb.Clieant.Generators
{
    // This class exists for no other reason than the fact that I do not want to have to replicate non-persisted data
    // every time I want to send out data for the "same" student; I may only ever end up using this once but typing
    // out all these fields has been less-than-awesome. 
    public class StudentDataGenerator
    {
        public Dictionary<string, CreateStudentData> Data { get; } = new Dictionary<string, CreateStudentData>()
        {
            {
                "@user1", new CreateStudentData()
                {
                    StudentId = 1111,
                    Name = "Bob Smith",
                    SSN = "221-22-2234",
                    EmailAddress = "bsmith@psu.edu",
                    HomePhone = "(555) 555 5555",
                    HomeAddress = "1234 E. Main St., Pittsburgh, PA 19002",
                    LocalAddress = "1234 W. Main St., Petersburg, VA, 22455",
                    EmergencyContact = "Jane Doe (555-555-5554)",
                    ProgramId = 4,
                    PaymentId = "1111-111",
                    AcademicStatus = 1,
                }
            },
            {
                 "@user2", new CreateStudentData()
                {
                    StudentId = 1111,
                    Name = "Becky Doe",
                    SSN = "221-22-2232",
                    EmailAddress = "bdoe@psu.edu",
                    HomePhone = "(555) 555 5553",
                    HomeAddress = "1234 E. Main St., Pittsburgh, PA 19002",
                    LocalAddress = "1234 W. Main St., Petersburg, VA, 22455",
                    EmergencyContact = "Jane Walter (555-555-5552)",
                    ProgramId = 4,
                    PaymentId = "1112-112",
                    AcademicStatus = 1,
                }
            }
        };
    }
}
