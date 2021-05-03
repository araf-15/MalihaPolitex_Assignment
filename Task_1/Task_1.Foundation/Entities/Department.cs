using System;
using System.Collections.Generic;
using System.Text;
using Task_1.Foundation.DataAccessLayer;

namespace Task_1.Foundation.Entities
{
    public class Department : IEntity<int>
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public IList<Student> Students { get; set; }
    }
}
