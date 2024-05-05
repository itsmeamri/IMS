using IMS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructures.Entity_Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<StoreInfo>

    {
        public void Configure(EntityTypeBuilder<StoreInfo> builder)
        {
            builder.HasKey(e=> e.Id);
            builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            builder.Property(e => e.StoreName)
                .HasMaxLength(256)
                .IsUnicode(true);

            builder.Property(e => e.Address)
                .HasMaxLength(256)
                .IsUnicode(true);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(true);

            builder.Property(e => e.RegistrationNo)
                .HasMaxLength(30)
                .IsUnicode(true);

            builder.Property(e => e.IsActive);

            builder.Property(e => e.CreatedDate)
            .IsRequired();


            builder.Property(e => e.CreatedBy)
            .IsRequired()
            .IsUnicode(true);

            builder.Property(e => e.ModifiedDatew);


            builder.Property(e => e.ModifiedBy)
            .IsRequired()
            .IsUnicode(true);






        }

    }

}
