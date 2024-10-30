using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class Sales
    {
        public byte? ProductId { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ItemGroup { get; set; }
        public string KitType { get; set; }
        public byte? Channels { get; set; }
        public string Demographic { get; set; }
    }
}
