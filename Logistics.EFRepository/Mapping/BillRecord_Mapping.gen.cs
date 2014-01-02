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
    
    internal partial class BillRecord_Mapping : EntityTypeConfiguration<BillRecord>
    {
        public BillRecord_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("BillRecords");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Fromdate).HasColumnName("Fromdate");
    		this.Property(t => t.Todate).HasColumnName("Todate");
    		this.Property(t => t.Remark).HasColumnName("Remark").HasMaxLength(255);
    		this.Property(t => t.Status).HasColumnName("Status").HasMaxLength(20);
    		this.Property(t => t.Createuser).HasColumnName("Createuser").HasMaxLength(50);
    		this.Property(t => t.Createtime).HasColumnName("Createtime");
    	}
    }
}