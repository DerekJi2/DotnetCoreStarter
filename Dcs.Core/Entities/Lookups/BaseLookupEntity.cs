using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dcs.Core.Entities
{
    public class BaseLookupEntity : Entity, IEntity, IEntityMethods, IBaseLookupEntity
    {
        public BaseLookupEntity() : base()
        {
            Code = "";
            DisplayName = "";
            Description = "";
            Json = "";
            ParentLookupId = null;
        }

        [MaxLength(20)]
        [Column(Order = 1)]
        public string Kind { get; set; }

        [MaxLength(20)]
        [Column(Order = 2)]
        public string Code { get; set; }

        [MaxLength(50)]
        [Column(Order = 3)]
        public string DisplayName { get; set; }

        [Column(Order = 4)]
        public int? DisplayOrder { get; set; }

        [MaxLength(255)]
        [Column(Order = 5)]
        public string Description { get; set; }

        [Column(Order = 501)]
        [ForeignKey("Parent")]
        public int? ParentLookupId { get; set; }

        [Column(TypeName = "text", Order = 502)]
        public string Json { get; set; }

        public IBaseLookupEntity Parent { get; set; }
    }
}
