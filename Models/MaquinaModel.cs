using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Crud.Models
{
    class MaquinaModel
    {
        [Key]
        public int IdMaquina { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }

        public String Material { get; set; }
        [ForeignKey("TipoModel")]
        public int IdTipo { get; set; }
        
        public TipoModel TipoModel{ get; set; }

    }
}
