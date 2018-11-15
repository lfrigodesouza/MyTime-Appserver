using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTime.Domain;
using MyTime.Domain.Enums;

namespace MyTime.Repository.Mappping
{
    public class TBLTaskMap
    {
        public TBLTaskMap(EntityTypeBuilder<TBLTask> entityBuilder)
        {
            entityBuilder.ToTable("TBLTask");
            entityBuilder.HasKey(t => t.IdTask);

            entityBuilder.Property(t => t.Code)
            .HasColumnType("varchar(10)")
            .IsRequired();

            entityBuilder.Property( t => t.Description)
            .HasColumnType("varchar(200)");

            entityBuilder.Property(t => t.Name)
            .HasColumnType("varchar(20)");

            entityBuilder.Property(t => t.DtCreation)
            .HasColumnType("datetime")
            .HasDefaultValueSql("NOW()")
            .IsRequired();

            entityBuilder.Property(t => t.DtFinished)
            .HasColumnType("datetime");

            entityBuilder.Property(t => t.DtStarted)
            .HasColumnType("datetime");

            entityBuilder.Property(t => t.TotalDuration)
            .HasColumnType("decimal")
            .HasDefaultValue(0)
            .IsRequired();

            var taskStatusConverter = new EnumToNumberConverter<Enums.EnTaskStatus, int>();
            entityBuilder.Property(t => t.TaskStatus)
            .HasColumnType("int")
            .HasDefaultValue(Enums.EnTaskStatus.Opened)
            .HasConversion(taskStatusConverter)
            .IsRequired();

            entityBuilder.HasMany(t => t.TBLAppointments)
            .WithOne(fk => fk.TBLTask)
            .HasForeignKey(t => t.IdAppointment);

            entityBuilder.HasOne( t => t.TBLUser)
            .WithMany(fk => fk.TBLTasks)
            .HasForeignKey(t => t.IdUser);

        }
    }
}