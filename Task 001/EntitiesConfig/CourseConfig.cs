using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Task_001
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            
            builder.HasKey(s => s.CrsId);
            builder.Property(s => s.CrsId).ValueGeneratedNever();
            builder.Property(s => s.Name).HasMaxLength(30).IsRequired();
            
        }

    }
}
