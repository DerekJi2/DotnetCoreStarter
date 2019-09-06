using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IModificationAudited : IHasModificationTime
    {
        /// <summary>
        /// Last modifier user for this entity.
        /// </summary>
        long? LastModifierUserId { get; set; }
    }

    /// <summary>
    /// Adds navigation properties to <see cref="IModificationAudited"/> interface for user.
    /// </summary>
    /// <typeparam name="TUser">Type of the user</typeparam>
    public interface IModificationAudited<TUser> : IModificationAudited
        where TUser : IEntity<long>
    {
        /// <summary>
        /// Reference to the last modifier user of this entity.
        /// </summary>
        TUser LastModifierUser { get; set; }
    }
}
