using AuthIdentityCustomized.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIdentityCustomized.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser        
    {
        //[ForeignKey("IdPersona")]
        //public Personas Personas { get; set; }
        //public int IdPersona { get; set; }
        
        public bool Externo { get; set; }

    }
}
