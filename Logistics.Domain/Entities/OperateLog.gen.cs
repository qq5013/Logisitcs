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
    
    public partial class OperateLog
    {
        public long Id { get; set; }
        public string ProcessName { get; set; }
        public string ProcessDesc { get; set; }
        public string MethodName { get; set; }
        public Nullable<int> UserID { get; set; }
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string MethodDesc { get; set; }
    }
}