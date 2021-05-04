using Autofac;
using Task_1.Areas.Admin.Models;

namespace Task_1
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DepartmentModel>().AsSelf();
            builder.RegisterType<StudentModel>().AsSelf();
            builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<RegistrationModel>().AsSelf();
            base.Load(builder);
        }
    }
}
