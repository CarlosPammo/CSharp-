using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EFE.Entity;


namespace EFE.Core.Map
{
    class AreaMap: EntityTypeConfiguration<Area>
    {
        public AreaMap(string schema)
        {
            ToTable("Area", schema);
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).HasColumnName("Id").IsRequired();
            Property(p => p.Name).HasColumnName("Name").IsRequired();
        }
    }
}
