using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Evento
    {

        public int EventoId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Máximo cinquenta caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public DateTime Data { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
