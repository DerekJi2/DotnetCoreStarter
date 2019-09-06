using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IHasDeletionTime : ISoftDelete
    {
        /// <summary>
        /// Deletion time of this entity.
        /// </summary>
        DateTime? DeletionTime { get; set; }
    }
}
