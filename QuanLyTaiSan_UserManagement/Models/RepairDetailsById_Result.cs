//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTaiSan_UserManagement.Models
{
    using System;
    
    public partial class RepairDetailsById_Result
    {
        public int Id { get; set; }
        public Nullable<int> DeviceId { get; set; }
        public Nullable<System.DateTime> DateOfRepair { get; set; }
        public Nullable<System.DateTime> NextDateOfRepair { get; set; }
        public Nullable<int> TimeOrder { get; set; }
        public Nullable<int> TypeOfRepair { get; set; }
        public string AddressOfRepair { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string FullName { get; set; }
        public string DeviceName { get; set; }
        public string TypeName { get; set; }
        public string DeviceCode { get; set; }
        public Nullable<double> Price { get; set; }
        public string DeviceTypeName { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string PriceOne { get; set; }
        public string PriceRepair { get; set; }
    }
}
