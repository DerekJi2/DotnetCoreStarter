using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IBaseEntity
    {
        #region Properties
        int Id { get; set; }
        DateTime Created { get; set; }

        DateTime LastModified { get; set; }

        string CreatedBy { get; set; }

        string ModifiedBy { get; set; }

        int Version { get; set; }

        bool Deleted { get; set; }
        #endregion Properties

        #region Methods
        bool Equals(object obj);

        int GetHashCode();

        string ToString();
        #endregion Methods
    }
}
