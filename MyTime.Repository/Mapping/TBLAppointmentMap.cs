using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTime.Domain;

namespace MyTime.Repository.Mappping
{
    public class TBLAppointmentMap
    {
        public TBLAppointmentMap(EntityTypeBuilder<TBLAppointment> entityBuilder)
        {
            entityBuilder.ToTable("TBLAppointment");
            entityBuilder.HasKey(t => t.IdAppointment);

            entityBuilder.Property(t => t.DtStart)
            .HasColumnType("datetime")
            .IsRequired();

            entityBuilder.Property(t => t.DtEnd)
            .HasColumnType("datetime");

            entityBuilder.Property(t => t.FlgDeleted)
            .HasColumnType("int")
            .HasDefaultValue(0)
            .IsRequired();

            entityBuilder.HasOne(fk => fk.TBLTask)
            .WithMany(t => t.TBLAppointments)
            .HasForeignKey(fk => fk.IdTask)
            .IsRequired();

        }
    }
}