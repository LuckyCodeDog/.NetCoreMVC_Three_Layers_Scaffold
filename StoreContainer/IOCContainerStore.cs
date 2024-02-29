using Autofac;
using IStore;
using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreContainer
{
    public class IOCContainerStore
    {
        public static IContainer? container = null;

        public static T Resolve<T>() where T : notnull
        {
            if (container == null) Instance();
            return container!.Resolve<T>();
        }

        public static void Instance()
        {
            var builder = new ContainerBuilder();
            //rigster conponents
            //builder.RegisterType<类>().As<接口>().InstancePerLifetimeScope();
            builder.RegisterType<StudentStore>().As<IStudentStore>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}
