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

        public class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                // تحديد اسم الجدول
                builder.ToTable("Users");

                // تعيين المفتاح الأساسي
                builder.HasKey(u => u.Id);

                // تعيين العلاقة مع Department
                builder.HasOne(u => u.Department)
                       .WithMany(d => d.Users)
                       .HasForeignKey(u => u.DepartmentID)
                       .OnDelete(DeleteBehavior.Restrict);

                // تعيين العلاقة مع Complaints
                builder.HasMany(u => u.Complaints)
                       .WithOne(c => c.User)
                       .HasForeignKey(c => c.UserID)
                       .OnDelete(DeleteBehavior.Restrict);

                // تعيين العلاقة مع AssignedComplaints
                builder.HasMany(u => u.AssignedComplaints)
                       .WithOne(c => c.AssignedTo)
                       .HasForeignKey(c => c.AssignedToID)
                       .OnDelete(DeleteBehavior.Restrict);
            }
        }
}

