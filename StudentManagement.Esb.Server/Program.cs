namespace StudentManagementEsb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shuttle.Core.ServiceHost.ServiceHost.Run<StudentManagement.Esb.Server.Server>();
        }
    }
}
