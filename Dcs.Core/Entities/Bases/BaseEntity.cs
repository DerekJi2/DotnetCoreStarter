using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities.Bases
{
    public abstract class BaseEntity : FullAuditedEntity, IBaseEntity
    {
        public BaseEntity()
        {
            IsDeleted = false;
        }
    }
}
