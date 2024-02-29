using Autofac;
using IService;
using Service;

namespace ServiceContainer
{
    public class IOCContainerService
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

            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}
