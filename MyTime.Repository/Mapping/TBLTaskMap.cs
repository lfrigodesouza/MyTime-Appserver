using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTime.Domain;

namespace MyTime.Repository.Mappping
{
    public class TBLTaskMap
    {
        public TBLTaskMap(EntityTypeBuilder<TBLTask> entityBuilder)
        {
            entityBuilder.ToTable("TBLTask");
            entityBuilder.HasKey(t => t.IdTask);

            entityBuilder.Property(t => t.Code)
            .HasColumnType("varchar")
            .HasMaxLength(10)
            .IsRequired();

            entityBuilder.Property( t => t.Description)
            .HasColumnType("varchar")
            .HasMaxLength(200);

            entityBuilder.Property(t => t.Name)
            .HasColumnType("varchar")
            .HasMaxLength(20);

            entityBuilder.Property(t => t.DtCreation)
            .HasColumnType("datetime")
            .IsRequired();

            entityBuilder.Property(t => t.DtFinished)
            .HasColumnType("datetime");

            entityBuilder.Property(t => t.DtFinished)
            .HasColumnType("datetime");
            
            entityBuilder.Property(t => t.DtStarted)
            .HasColumnType("datetime");

            entityBuilder.Property(t => t.TotalDuration)
            .HasColumnType("decimal")
            .IsRequired();

            entityBuilder.HasOne(t => t.TBLUser)
            .WithMany(fk => fk.TBLTasks)
            .HasForeignKey(t => t.IdUser)
            .IsRequired();

            entityBuilder.HasMany(t => t.TBLAppointments)
            .WithOne(fk => fk.TBLTask)
            .HasForeignKey(t => t.IdAppointment);

        }
    }
}