using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.CustomModel
{
    using System;
    using System.Collections.Generic;

    public partial class VW_Company
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Rating { get; set; }
        public string Attention { get; set; }
        public int CompanyCategoryId { get; set; }
        public bool IsActive { get; set; }
        public string CategoryName { get; set; }
    }
}