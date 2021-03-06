﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1573
namespace Logistics.EFRepository
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Logistics.Domain.Entities;
    using Logistics.EFRepository.Mapping;
    
    public partial class LogisticsEntities : DbContext
    {
        static LogisticsEntities()
    	{ 
    		Database.SetInitializer<LogisticsEntities>(null);
    	}
    	
    	public LogisticsEntities() : base("name=LogisticsEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    	
    	public LogisticsEntities(string nameOrConnectionString) : base(nameOrConnectionString)
    	{	
    	}
    
    	public LogisticsEntities(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
    	{
    	}
    
    	public LogisticsEntities(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
    	{
    	}
    
    	public LogisticsEntities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
    	{
    	}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
    		modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
    		modelBuilder.Configurations.Add(new Bill_Mapping());
    		modelBuilder.Configurations.Add(new BillDetail_Mapping());
    		modelBuilder.Configurations.Add(new BillRecord_Mapping());
    		modelBuilder.Configurations.Add(new Button_Mapping());
    		modelBuilder.Configurations.Add(new Charge_Mapping());
    		modelBuilder.Configurations.Add(new Contract_Mapping());
    		modelBuilder.Configurations.Add(new ContractRate_Mapping());
    		modelBuilder.Configurations.Add(new Customer_Mapping());
    		modelBuilder.Configurations.Add(new Department_Mapping());
    		modelBuilder.Configurations.Add(new Group_Mapping());
    		modelBuilder.Configurations.Add(new Job_Mapping());
    		modelBuilder.Configurations.Add(new LoginUser_Mapping());
    		modelBuilder.Configurations.Add(new Memorycard_Mapping());
    		modelBuilder.Configurations.Add(new Menu_Mapping());
    		modelBuilder.Configurations.Add(new OperateLog_Mapping());
    		modelBuilder.Configurations.Add(new Product_Mapping());
    		modelBuilder.Configurations.Add(new ProductBatch_Mapping());
    		modelBuilder.Configurations.Add(new ProductBrand_Mapping());
    		modelBuilder.Configurations.Add(new ProductMaterial_Mapping());
    		modelBuilder.Configurations.Add(new ProductModule_Mapping());
    		modelBuilder.Configurations.Add(new Rack_Mapping());
    		modelBuilder.Configurations.Add(new Role_Mapping());
    		modelBuilder.Configurations.Add(new Stock_Mapping());
    		modelBuilder.Configurations.Add(new StockDetail_Mapping());
    		modelBuilder.Configurations.Add(new StockMove_Mapping());
    		modelBuilder.Configurations.Add(new Store_Mapping());
    		modelBuilder.Configurations.Add(new VenueStaff_Mapping());
        }
    	
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<BillRecord> BillRecords { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Button> Buttons { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<ContractRate> ContractRates { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Memorycard> Memorycards { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OperateLog> OperateLogs { get; set; }
        public DbSet<ProductBatch> ProductBatchs { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<ProductModule> ProductModules { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rack> Racks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StockDetail> StockDetails { get; set; }
        public DbSet<StockMove> StockMoves { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<VenueStaff> VenueStaffs { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
    }
}
