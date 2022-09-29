using CadastroDeVeiculosEtec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDeVeiculosEtec.Data.Mappings
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(veiculo => veiculo.Id);

            builder.Property(lbda => lbda.Codigo)
               .IsRequired()
               .HasColumnType("varchar(15)");

            builder.Property(lbda => lbda.Marca)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(lbda => lbda.Modelo)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(lbda => lbda.Fabricante)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(lbda => lbda.Cor)
                .IsRequired()
                .HasColumnType("varchar(25)");

            builder.Property(lbda => lbda.Chassi)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(lbda => lbda.Observacao)
                .HasColumnType("varchar(150)");


            builder.ToTable("Veiculos");
        }
    }
}
