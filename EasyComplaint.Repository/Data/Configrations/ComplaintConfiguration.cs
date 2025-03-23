﻿using EasyComplaint.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyComplaint.Repository.Data.Configrations
{
    public class ComplaintConfiguration : IEntityTypeConfiguration<Complaint>
    {
        public void Configure(EntityTypeBuilder<Complaint> builder)
        {
           
           

            // تعيين المفتاح الأساسي
            builder.HasKey(c => c.Id);

            // تعيين الحقول المطلوبة وطولها
            builder.Property(c => c.Status)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.Description)
                   .IsRequired()
                   .HasMaxLength(500);
                  

            // تعيين العلاقة مع User (مقدم الشكوى)
            builder.HasOne(c => c.User)
                   .WithMany(u => u.Complaints)
                   .HasForeignKey(c => c.UserID)
                   .OnDelete(DeleteBehavior.Restrict);

            // تعيين العلاقة مع ComplaintType
            builder.HasOne(c => c.ComplaintType)
                   .WithMany(ct => ct.Complaints)
                   .HasForeignKey(c => c.ComplaintTypeID)
                   .OnDelete(DeleteBehavior.Restrict);

            // تعيين العلاقة مع Workflow (الخطوة الحالية)
            builder.HasOne(c => c.CurrentStep)
                   .WithMany(w=>w.Complaints)
                   .HasForeignKey(c => c.CurrentStepID)
                   .OnDelete(DeleteBehavior.Restrict);

            // تعيين العلاقة مع User (المسند إليه)
            builder.HasOne(c => c.AssignedTo)
                   .WithMany(u => u.AssignedComplaints)
                   .HasForeignKey(c => c.AssignedToID)
                   .OnDelete(DeleteBehavior.Restrict);

            // تعيين العلاقة مع Comments
            builder.HasMany(c => c.Comments)
                   .WithOne(cm => cm.Complaint)
                   .HasForeignKey(cm => cm.ComplaintID)
                   .OnDelete(DeleteBehavior.Cascade);

            // تعيين العلاقة مع Attachments
            builder.HasMany(c => c.Attachments)
                   .WithOne(a => a.Complaint)
                   .HasForeignKey(a => a.ComplaintID)
                   .OnDelete(DeleteBehavior.Cascade);

            // تعيين العلاقة مع ComplaintParticipants
            builder.HasMany(c => c.Participants)
                   .WithOne(cp => cp.Complaint)
                   .HasForeignKey(cp => cp.ComplaintID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

 
}
