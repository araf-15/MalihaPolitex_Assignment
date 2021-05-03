using Autofac;
using Task_1.Foundation.Contexts;
using Task_1.Foundation.Entities;
using Task_1.Foundation.Repositories;
using Task_1.Foundation.Services;
using Task_1.Foundation.UnitOfWorks;

namespace Task_1.Foundation
{
    public class FoundationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoundationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //Context Binding
            builder.RegisterType<StudentManagementContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentManagementContext>().As<IStudentManagementContext>().InstancePerLifetimeScope();

            //Entity Binding
            builder.RegisterType<Department>().AsSelf();
            builder.RegisterType<Student>().AsSelf();
            builder.RegisterType<Course>().AsSelf();
            builder.RegisterType<Registration>().AsSelf();

            //Repository Binding
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CourseRepository>().As<ICourseRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RegistrationRepository>().As<IRegistrationRepository>().InstancePerLifetimeScope();

            //Service Binding
            builder.RegisterType<DepartmentService>().As<IDepartmentService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
            builder.RegisterType<CourseService>().As<ICourseService>().InstancePerLifetimeScope();
            builder.RegisterType<RegistrationService>().As<IRegistrationService>().InstancePerLifetimeScope();

            //Unit of work binding
            builder.RegisterType<DepartmentUnitOfWork>().As<IDepartmentUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<StudentUnitOfWork>().As<IStudentUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CourseUnitOfWork>().As<ICourseUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<RegistrationUnitOfWork>().As<IRegistrationUnitOfWork>().InstancePerLifetimeScope();

            base.Load(builder);
        }

    }
}
