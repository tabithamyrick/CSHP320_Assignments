using System;
using System.Collections.Generic;

#nullable disable

namespace CSHP320_InventoryManagementProject
{
    public partial class Inventory
    {
        public int InvNum { get; set; }
        public int Model { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public decimal? InvValue { get; set; }
        public int? ImageNum { get; set; }
    }
}
