using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Foundation.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
