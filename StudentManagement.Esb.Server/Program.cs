﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementEsb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shuttle.Core.ServiceHost.ServiceHost.Run<StudentManagement.Esb.Server.Host>();
        }
    }
}
