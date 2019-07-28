namespace StudentManagement.Esb.Messages.Commands
{
    public class CreateStudentData
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddress { get; set; }
        public string LocalAddress { get; set; }
        public string EmergencyContact { get; set; }
        public int ProgramId { get; set; }
        public string PaymentId { get; set; }
        public int AcademicStatus { get; set; }
    }
}
