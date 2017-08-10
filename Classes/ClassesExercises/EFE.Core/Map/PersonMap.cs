using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFE.Entity;

namespace EFE.Core.Map
{
    class PersonMap: EntityTypeConfiguration<Person>
    {
        public PersonMap(string schema)
        {
            ToTable("Person", schema);
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).HasColumnName("Id").IsRequired();
            Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
            Property(p => p.LastName).HasColumnName("LastName").IsRequired();
        }
    }
}
