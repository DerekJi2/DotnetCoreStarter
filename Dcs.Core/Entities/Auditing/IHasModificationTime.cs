using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IHasModificationTime
    {
        /// <summary>
        /// The last modified time for this entity.
        /// </summary>
        DateTime? LastModificationTime { get; set; }
    }
}
