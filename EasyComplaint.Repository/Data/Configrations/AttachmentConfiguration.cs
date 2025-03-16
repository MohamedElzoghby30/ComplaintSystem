using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyComplaint.Core.Entities;

namespace EasyComplaint.Repository.Data.Configrations
{
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.Property(a => a.FilePath)
                   .IsRequired();

            builder.Property(a => a.FileType)
                   .IsRequired()
                   .HasMaxLength(50);

            // العلاقة مع Complaint
            builder.HasOne(a => a.Complaint)
                   .WithMany(c => c.Attachments)
                   .HasForeignKey(a => a.ComplaintID)
                   .OnDelete(DeleteBehavior.Restrict);

            // العلاقة مع User
            builder.HasOne(a => a.User)
                   .WithMany()
                   .HasForeignKey(a => a.UploadedBy)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
