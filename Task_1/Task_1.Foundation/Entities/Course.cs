using System;
using System.Collections.Generic;
using System.Text;
using Task_1.Foundation.DataAccessLayer;

namespace Task_1.Foundation.Entities
{
    public class Course : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }

        public IList<Registration> Registrations { get; set; }
    }
}
