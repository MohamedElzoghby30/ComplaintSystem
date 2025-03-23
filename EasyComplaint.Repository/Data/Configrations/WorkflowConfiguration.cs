using EasyComplaint.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Repository.Data.Configrations
{
    public class WorkflowConfiguration : IEntityTypeConfiguration<Workflow>
    {
        public void Configure(EntityTypeBuilder<Workflow> builder)
        {
          
            builder.HasKey(w => w.Id);

            builder.Property(w => w.StepName)
                   .IsRequired()
                   .HasMaxLength(100);

            // تعيين العلاقة مع ComplaintType
            builder.HasOne(w => w.ComplaintType)
                   .WithMany()
                   .HasForeignKey(w => w.ComplaintTypeID)
                   .OnDelete(DeleteBehavior.Restrict);

            // تعيين العلاقة مع NextStep
            builder.HasOne(w => w.NextStep)
                   .WithMany()
                   .HasForeignKey(w => w.NextStepID)
                   .OnDelete(DeleteBehavior.Restrict);

            // تعيين العلاقة مع Role
            builder.HasOne(w => w.Role)
                   .WithMany()
                   .HasForeignKey(w => w.RoleID)
                   .OnDelete(DeleteBehavior.Restrict);
            //علاقه مع Complaint
            builder.HasMany(w => w.Complaints)
                 .WithOne(c => c.CurrentStep)
                 .HasForeignKey(c => c.CurrentStepID)
                 .OnDelete(DeleteBehavior.SetNull);
        }
    }

}
