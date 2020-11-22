using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {

            // Configurando as propriedades
            builder.Property(s => s.ServicoId);
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Valor).IsRequired();
            // Configurando um Enum
            builder.Property(s => s.Status).IsRequired();

            // Configurando o relacionamento entre serviço e usuário
            // Chave primária da tabela Usuario + relacionamento
            builder.Property(s => s.UsuarioId).IsRequired();
            builder.HasOne(s => s.Usuario).WithMany(s => s.Servicos).HasForeignKey(s => s.UsuarioId);

            // Criando um relacionamento entre serviço e serviçoPredios
            builder.HasMany(s => s.ServicoPredios).WithOne(s => s.Servico);

            builder.ToTable("Servicos");

        }
    }
}
