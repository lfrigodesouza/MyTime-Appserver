using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTime.Domain;

namespace MyTime.Repository.Mappping
{
    public class TBLUserMap
    {
        public TBLUserMap(EntityTypeBuilder<TBLUser> entityBuilder)
        {
            entityBuilder.ToTable("TBLUser");

            entityBuilder.HasKey(t => t.IdUser);

            entityBuilder.Property(t => t.Code)
            .HasColumnType("varchar")
            .HasMaxLength(10)
            .IsRequired();

            entityBuilder.Property(t => t.Name)
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

            entityBuilder.Property(t => t.Password)
            .HasColumnType("varchar")
            .HasMaxLength(256)
            .IsRequired();

            entityBuilder.Property(t => t.UserType)
            .HasColumnType("int")
            .IsRequired();

            entityBuilder.Property(t => t.FlgEnable)
            .HasColumnType("int")
            .IsRequired();

            entityBuilder.HasMany(t => t.TBLTasks)
            .WithOne(fk => fk.TBLUser)
            .HasForeignKey(t => t.IdUser)
            .IsRequired();
        

        }
    }
}