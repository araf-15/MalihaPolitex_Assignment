﻿using Task_1.Foundation.DataAccessLayer;
using Task_1.Foundation.Repositories;

namespace Task_1.Foundation.UnitOfWorks
{
    public interface IDepartmentUnitOfWork : IUnitOfWork
    {
        IDepartmentRepository DepartmentRepository { get; set; }
    }
}
