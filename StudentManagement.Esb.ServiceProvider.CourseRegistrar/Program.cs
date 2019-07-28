using Shuttle.Core.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Esb.ServiceProvider.CourseRegistrar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Run<ServiceProvider>();
        }
    }
}
