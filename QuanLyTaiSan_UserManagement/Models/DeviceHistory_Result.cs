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
    
    public partial class DeviceHistory_Result
    {
        public string ProjectName { get; set; }
        public Nullable<int> DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Configuration { get; set; }
        public Nullable<int> TypeOfDevice { get; set; }
        public Nullable<System.DateTime> DateOfDelivery { get; set; }
        public Nullable<System.DateTime> DateOfReturn { get; set; }
        public string Notes { get; set; }
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string DeviceCode { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> StatusRepair { get; set; }
    }
}
