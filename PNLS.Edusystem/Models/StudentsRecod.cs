using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNLS.Edusystem.Models
{
    public class StudentsRecod
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(20)")]
        public string Name { get; set; }
        [Required]
        [Column("fatherName", TypeName = "varchar(20)")]
        public string fatherName { get; set; }
        [Required]
        [Column("Gender", TypeName = "varchar(8)")]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [Column("Level", TypeName = "varchar(20)")]
        public string Level { get; set; }
        [Required]
        [Column("Deparment", TypeName = "varchar(20)")]
        public string Deparment { get; set; }
        [Required]
        [Column("Mobile", TypeName = "varchar(13)")]
        public string Mobile { get; set; }
        [Required]
        [Column("Adress", TypeName = "varchar(100)")]
        public string Adress { get; set; }
        [Required]
        [Column("City", TypeName = "varchar(30)")]
        public string City { get; set; }
        [Required]
        [Column("Distrit", TypeName = "varchar(50)")]
        public string Distrit { get; set; }
        [Required]
        [Column("provence", TypeName = "varchar(50)")]
        public string provence { get; set; }
        [Required]
        [Column("Country", TypeName = "varchar(50)")]
        public string Country { get; set; }
        public int fee { get; set; }
        [Required]
        public DateTime Joindate { get; set; }

    }
    
}
