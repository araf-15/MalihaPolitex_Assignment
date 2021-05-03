using System;
using System.Collections.Generic;
using System.Text;
using Task_1.Foundation.Contexts;
using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Entities;

namespace Task_1.Foundation.Repositories
{
    public class RegistrationRepository : Repository<Registration, int, StudentManagementContext>, IRegistrationRepository
    {
        public RegistrationRepository(StudentManagementContext context) : base(context) { }
    }
}
