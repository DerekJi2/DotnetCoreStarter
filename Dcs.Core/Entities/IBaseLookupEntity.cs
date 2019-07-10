using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IBaseLookupEntity
    {
        #region Properties
        string Code { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        string Json { get; set; }
        int? ParentLookupId { get; set; }
        #endregion Properties
    }
}
