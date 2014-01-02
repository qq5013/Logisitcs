//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistics.EFRepository.Mapping
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    using Logistics.Domain.Entities;
    
    internal partial class OperateLog_Mapping : EntityTypeConfiguration<OperateLog>
    {
        public OperateLog_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("OperateLogs");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.ProcessName).HasColumnName("ProcessName").HasMaxLength(50);
    		this.Property(t => t.ProcessDesc).HasColumnName("ProcessDesc").HasMaxLength(100);
    		this.Property(t => t.MethodName).HasColumnName("MethodName").HasMaxLength(50);
    		this.Property(t => t.UserID).HasColumnName("UserID");
    		this.Property(t => t.UserName).HasColumnName("UserName").HasMaxLength(30);
    		this.Property(t => t.IPAddress).HasColumnName("IPAddress").HasMaxLength(100);
    		this.Property(t => t.Description).HasColumnName("Description").HasMaxLength(200);
    		this.Property(t => t.CreateDate).HasColumnName("CreateDate");
    		this.Property(t => t.MethodDesc).HasColumnName("MethodDesc").HasMaxLength(100);
    	}
    }
}