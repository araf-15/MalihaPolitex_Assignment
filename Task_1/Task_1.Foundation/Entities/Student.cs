using System;
using System.Collections.Generic;
using System.Text;
using Task_1.Foundation.DataAccessLayer;

namespace Task_1.Foundation.Entities
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public DateTime DateOfBirth { get; set; }


        public IList<Registration> Registrations { get; set; }
    }
}
