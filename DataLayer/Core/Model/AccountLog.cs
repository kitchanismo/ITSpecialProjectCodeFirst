//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountLog
    {
        public int Id { get; set; }
        public string Rfid { get; set; }
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string LockCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        public bool Flag { get; set; }
        public string CommandType { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
