using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public class BaseLookupEntity : BaseEntity, IBaseLookupEntity
    {
        public BaseLookupEntity() : base()
        {
            Code = "";
            DisplayName = "";
            Description = "";
            Json = "";
            ParentLookupId = null;
        }

        public string Code { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Json { get; set; }

        public int? ParentLookupId { get; set; }
    }
}
