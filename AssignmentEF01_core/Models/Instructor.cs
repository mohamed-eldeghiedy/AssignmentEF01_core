using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AssignmentEF01_core.Models
{

    //  Data Annotations


    [Table("Instructor")] 
    public class Instructor
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column("Bonus", TypeName = "decimal(18,2)")]
        public decimal Bonus { get; set; }

        [Required]
        [Column("Salary", TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("Address", TypeName = "nvarchar(200)")]
        public string Address { get; set; }

        [Required]
        [Column("HourRate", TypeName = "decimal(18,2)")]
        public decimal HourRate { get; set; }

        [Required]
        [Column("Dept_ID")]
        public int Dept_ID { get; set; }
    }
}
