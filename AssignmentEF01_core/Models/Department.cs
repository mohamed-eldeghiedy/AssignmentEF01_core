using System;


namespace AssignmentEF01_core.Models
{
    // by convention
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Manager_ID { get; set; }
        public DateTime HireDate { get; set; }
    }
}
