using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Crud.Models
{
    class TipoModel
    {
        [Key]
        public int IdTipo { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        
        public List<MaquinaModel> MaquinaModels { get; set; }
    }
}
