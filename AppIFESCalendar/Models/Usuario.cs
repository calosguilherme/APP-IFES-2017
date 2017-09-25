using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace usuario.Models
{
    [Table("categoria")]
    public class Categoria
    {
        [Key]
        [Display(Name = "Código")]
        [Column(Order = 0)]
        public Int32 idcodigo { get; set; }

        [Display(Name = "Nome")]
        [Column(Order = 1)]
        public string nome { get; set; }

        [ForeignKey("Senha")]
        public string senha { get; set; }


        [Display(Name = "Email")]
        [Column(Order = 2)]
        public string email { get; set; }
        
    }
}