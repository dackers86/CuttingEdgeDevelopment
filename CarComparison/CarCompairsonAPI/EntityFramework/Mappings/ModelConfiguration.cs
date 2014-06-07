using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CarCompairsonAPI.EntityFramework.Mappings
{
    public class ModelConfiguration : EntityTypeConfiguration<Model>
    {
        public ModelConfiguration()
        {
            HasKey(p => p.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).IsRequired();
            Property(c => c.NoughtToSixty).IsRequired();
            HasRequired(m => m.Manufacturer).WithMany(c => c.Models).HasForeignKey(m => m.Id);
        }
    }
}