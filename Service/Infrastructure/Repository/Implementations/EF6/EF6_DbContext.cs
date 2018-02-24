using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EF6
{
    public class EF6_DbContext : DbContext
    {
        public EF6_DbContext() : base("name=EntityFramework6")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {                       
            modelBuilder.Entity<Candidato>().Property(x => x.Nome).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.Email).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.Skype).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.Telefone).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.TelefoneEWhatsApp).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.Disponibilidade).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.HorarioDeTrabalho).IsRequired();
            modelBuilder.Entity<Candidato>().Property(x => x.PretensaoRemuneracaoPorHora).HasPrecision(10, 2).IsRequired();
            modelBuilder.Entity<Candidato>().HasRequired(x => x.Localizacao)
                .WithRequiredPrincipal(x => x.Candidato).WillCascadeOnDelete(true);
            modelBuilder.Entity<Candidato>().HasRequired(x => x.InformacaoParaPagamento)
                .WithRequiredPrincipal(x => x.Candidato).WillCascadeOnDelete(true);
            modelBuilder.Entity<Candidato>().HasRequired(x => x.Conhecimentos)
                .WithRequiredPrincipal(x => x.Candidato).WillCascadeOnDelete(true);

            modelBuilder.Entity<Conhecimentos>().Property(x => x.Ionic).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.Android).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.IOS).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.Bootstrap).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.JQuery).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.AngularJS).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.AspNetMVC).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.PHP).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.Wordpress).IsRequired();
            modelBuilder.Entity<Conhecimentos>().Property(x => x.Outras).HasMaxLength(800);
            modelBuilder.Entity<Conhecimentos>().HasRequired(x => x.Candidato)
                .WithRequiredDependent(x => x.Conhecimentos).WillCascadeOnDelete(true);

            modelBuilder.Entity<InformacaoParaPagamento>().Property(x => x.NomeTitular).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<InformacaoParaPagamento>().Property(x => x.CPF).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<InformacaoParaPagamento>().Property(x => x.Banco).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<InformacaoParaPagamento>().Property(x => x.Agencia).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<InformacaoParaPagamento>().Property(x => x.NumeroDaConta).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<InformacaoParaPagamento>().Property(x => x.TipoDeConta).IsRequired();
            modelBuilder.Entity<InformacaoParaPagamento>().HasRequired(x => x.Candidato)
                .WithRequiredDependent(x => x.InformacaoParaPagamento).WillCascadeOnDelete(true);

            modelBuilder.Entity<Localizacao>().Property(x => x.Cidade).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Localizacao>().Property(x => x.Estado).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Localizacao>().HasRequired(x => x.Candidato)
                .WithRequiredDependent(x => x.Localizacao).WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
