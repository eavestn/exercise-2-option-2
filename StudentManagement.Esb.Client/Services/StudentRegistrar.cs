using Shuttle.Core.Container;
using Shuttle.Esb;
using StudentManagement.Esb.Clieant.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Esb.Clieant.Services
{
    public class StudentRegistrar
    {
        private IComponentResolver _resolver;

        public StudentRegistrar(IComponentResolver resolver)
        {
            this._resolver = resolver;
        }

        public StudentRegistrar Start()
        {
            using (var bus = ServiceBus.Create(this._resolver).Start())
            {
                string userName;

                while (!string.IsNullOrEmpty(userName = Console.ReadLine()))
                {
                    if (new StudentDataGenerator().Data.TryGetValue(userName, out var data))
                    {
                        bus.Send(data);
                    }
                }
            }

            return this;
        }
    }
}
