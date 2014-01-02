//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistics.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public Contract()
        {
            this.ContractRates = new HashSet<ContractRate>();
        }
    
        public int Id { get; set; }
        public string Manualno { get; set; }
        public Nullable<int> Customerid { get; set; }
        public string Mncode { get; set; }
        public Nullable<bool> Israilway { get; set; }
        public bool Ishighway { get; set; }
        public bool Iscontainer { get; set; }
        public bool Isexpire { get; set; }
        public Nullable<int> Settday { get; set; }
        public Nullable<decimal> Delaycost { get; set; }
        public Nullable<System.DateTime> Startime { get; set; }
        public Nullable<System.DateTime> Endtime { get; set; }
        public string Demoid { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public string Modifyuser { get; set; }
        public System.DateTime Modifytime { get; set; }
    
        public virtual ICollection<ContractRate> ContractRates { get; set; }
        public virtual Customer Customer { get; set; }
    }
}