using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface ICreationAudited : IHasCreationTime
    {
        /// <summary>
        /// Id of the creator user of this entity.
        /// </summary>
        long? CreatorUserId { get; set; }
    }

    /// <summary>
    /// Adds navigation properties to <see cref="ICreationAudited"/> interface for user.
    /// </summary>
    /// <typeparam name="TUser">Type of the user</typeparam>
    public interface ICreationAudited<TUser> : ICreationAudited
        where TUser : IEntity<long>
    {
        /// <summary>
        /// Reference to the creator user of this entity.
        /// </summary>
        TUser CreatorUser { get; set; }
    }

}
