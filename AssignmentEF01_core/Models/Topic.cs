using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AssignmentEF01_core.Models
{
    internal class Topic
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name", TypeName = "nvarchar(100)")]
        public string Name { get; set; } = string.Empty;
    }
}
