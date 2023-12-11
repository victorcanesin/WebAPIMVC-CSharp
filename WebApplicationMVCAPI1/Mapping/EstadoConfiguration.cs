using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplicationMVCAPI1.Models;

namespace WebApplicationMVCAPI1.Mapping
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("tbl_geral_estado");

            builder.HasKey(x => x.estadoCodigo);

            builder.Property(x => x.estadoCodigo).HasColumnName("estado_codigo");

            builder.Property(x => x.estadoDescricao).HasColumnName("estado_descricao");

            builder.Property(x => x.estadoSigla).HasColumnName("estado_sigla");

            builder.Property(x => x.paisCodigo).HasColumnName("pais_codigo");

        }

    }
}
