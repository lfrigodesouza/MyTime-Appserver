using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTime.Domain;
using MyTime.Domain.Enums;

namespace MyTime.Repository.Mappping
{
    public class TBLUserMap
    {
        public TBLUserMap(EntityTypeBuilder<TBLUser> entityBuilder)
        {
            entityBuilder.ToTable("TBLUser");

            entityBuilder.HasKey(t => t.IdUser);

            entityBuilder.Property(t => t.Code)
            .HasColumnType("varchar(10)")
            .IsRequired();

            entityBuilder.Property(t => t.Name)
            .HasColumnType("varchar(25)")
            .IsRequired();

            entityBuilder.Property(t => t.Password)
            .HasColumnType("varchar(256)")
            .IsRequired();


            var userTypeConverter = new EnumToNumberConverter<Enums.EnUserType, int>();
            entityBuilder.Property(t => t.UserType)
            .HasColumnType("int")
            .HasDefaultValue(Enums.EnUserType.NormalUser)
            .HasConversion(userTypeConverter)
            .IsRequired();

            entityBuilder.Property(t => t.FlgEnable)
            .HasColumnType("int")
            .HasDefaultValue(1)
            .IsRequired();

            entityBuilder.HasMany(t => t.TBLTasks)
            .WithOne(fk => fk.TBLUser)
            .HasForeignKey(t => t.IdUser)
            .IsRequired();
        

        }
    }
}