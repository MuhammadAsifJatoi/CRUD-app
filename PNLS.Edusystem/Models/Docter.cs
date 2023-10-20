using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNLS.Edusystem.Models
{
    public class Docter
    {
        public int id { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(100)")]
        public string name { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(100)")]
        public string Speclist { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(100)")]
        public string description { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(100)")]
        public string Hospetalroom { get; set; }
    }
}
