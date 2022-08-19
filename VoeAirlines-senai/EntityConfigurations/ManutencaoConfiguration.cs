using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlinesSenai.EntityConfigurations;

public class ManutencaoConfiguration:IEntityTypeConfiguration<Manutencao>
{
   public void Configure (EntityTypeBuilder<Manutencao> builder)
   {
   builder.ToTable("Manutencao");
   builder.HasKey(m=>m.Id);
   builder.Property(m=>m.DataHora)
          .IsRequired()
          .HasMaxLength(80);
   builder.Property(m=>m.Observacoes)
          .IsRequired()
          .HasMaxLength(10);
    builder.Property(m=>m.Tipo)
          .IsRequired()
          .HasMaxLength(100);
   }

}

