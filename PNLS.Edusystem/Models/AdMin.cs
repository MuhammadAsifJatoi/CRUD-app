using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNLS.Edusystem.Models
{
    public class AdMin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column("Email", TypeName = "varchar(30)")]
        public string Email { get; set; }
        [Required]
        [Column("Phone", TypeName = "varchar(30)")]
        public string Phone { get; set; }
        [Required]
        [Column("UserName", TypeName = "varchar(30)")]
        public string UserName { get; set; }
        [Required]
        [Column("Password", TypeName = "varchar(30)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
