using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IBaseLookupEntity
    {
        #region Properties
        [MaxLength(20)]
        [Column(Order = 1)]
        string Kind { get; set; }

        [MaxLength(20)]
        [Column(Order = 2)]
        string Code { get; set; }

        [MaxLength(50)]
        [Column(Order = 3)]
        string DisplayName { get; set; }

        [Column(Order = 4)]
        int? DisplayOrder { get; set; }

        [MaxLength(255)]
        [Column(Order = 5)]
        string Description { get; set; }

        [Column(Order = 501)]
        [ForeignKey("Parent")]
        int? ParentLookupId { get; set; }

        [Column(TypeName = "text", Order = 502)]
        string Json { get; set; }
                
        IBaseLookupEntity Parent { get; set; }
        #endregion Properties
    }
}
