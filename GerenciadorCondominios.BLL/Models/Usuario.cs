using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text;
using System.Net;
using GerenciadorCondominios.BLL.Models;

namespace GerenciadorCondominios.BLL
{
    public class Usuario : IdentityUser<string>
    {

        public string CPF { get; set; }
        public string Foto { get; set; }
        public Boolean PrimeiroAcesso { get; set; }
        public StatusConta Status { get; set; }

        // Propriedades Navegacionais - Chaves Estrangeiras
        public virtual ICollection<Apartamento> MoradoresApartamentos { get; set; }
        public virtual ICollection<Apartamento> ProprietariosApartamentos { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }

    }

    public enum StatusConta
    {
        Analisando, Aprovado, Reprovado
    }

}
