using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dcs.Core.Entities
{
    public interface IBaseEntity
    {
        #region Properties
        [Key]
        [Column(Order = 0)]
        int Id { get; set; }

        [Column(Order = 1001)]
        DateTime Created { get; set; }

        [Column(Order = 1002)]
        DateTime LastModified { get; set; }

        [Column(Order = 1003)]
        [MaxLength(50)]
        string CreatedBy { get; set; }

        [Column(Order = 1004)]
        [MaxLength(50)]
        string ModifiedBy { get; set; }

        [Column(Order = 1005)]
        bool Deleted { get; set; }

        [Column(Order = 1006)]
        int Version { get; set; }
        #endregion Properties

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Equals(object obj);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetHashCode();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string ToString();
        #endregion Methods
    }
}
