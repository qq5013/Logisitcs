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
    
    internal partial class ProductBatch_Mapping : EntityTypeConfiguration<ProductBatch>
    {
        public ProductBatch_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("ProductBatchs");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Name).HasColumnName("Name").HasMaxLength(100);
    		this.Property(t => t.Proid).HasColumnName("Proid");
    		this.Property(t => t.Remark).HasColumnName("Remark").HasMaxLength(255);
    		this.Property(t => t.Status).HasColumnName("Status").IsRequired().HasMaxLength(2);
    		this.Property(t => t.Modifyuser).HasColumnName("Modifyuser").IsRequired().HasMaxLength(12);
    		this.Property(t => t.Modifytime).HasColumnName("Modifytime");
    		this.HasOptional(t => t.Product).WithMany(t => t.ProductBatchs).HasForeignKey(d => d.Proid);
    	}
    }
}
