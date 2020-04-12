using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIdentityCustomized.Models
{
    public class Personas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Column(TypeName = "varchar(150)")]
        [DisplayName("Nombre")]
        public string Documento { get; set; }

        [DisplayName("tipo Documento")]
        public int TipoDocumento { get; set; }

        [Column(TypeName = "varchar(150)")]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(150)")]
        [DisplayName("Apellido")]
        public string Apellido { get; set; }

        public bool Activo { get; set; }

        [Column(TypeName = "Date")]
        [DisplayName("fecha Creacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? fechaCreacion { get; set; }

    }

   
}
