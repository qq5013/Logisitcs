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
    
    public partial class ProductBatch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Proid { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public string Modifyuser { get; set; }
        public System.DateTime Modifytime { get; set; }
    
        public virtual Product Product { get; set; }
    }
}