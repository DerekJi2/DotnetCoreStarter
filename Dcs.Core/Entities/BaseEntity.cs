using Dcs.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Dcs.Core.Entities
{
    public abstract class BaseEntity: BaseClass, IBaseEntityBO, IBaseEntityBiz
    {
        public BaseEntity()
        {
            var now = DateTime.Now;
            Id = 0;
            Created = now;
            LastModified = now;
            CreatedBy = "";
            ModifiedBy = "";
            Version = 1;
            Deleted = false;
            Guid = System.Guid.NewGuid().ToString();
        }

        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1001)]
        public DateTime Created { get; set; }

        [Column(Order = 1002)]
        public DateTime LastModified { get; set; }

        [Column(Order = 1003)]
        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column(Order = 1004)]
        [MaxLength(50)]
        public string ModifiedBy { get; set; }

        [Column(Order = 1005)]
        public bool Deleted { get; set; }

        [Column(Order = 1006)]
        public int Version { get; set; }
        
        [Column(Order = 1007)]
        public string Guid { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseEntity))
            {
                return false;
            }

            //Same instances must be considered as equal
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            //Transient objects are not considered as equal
            var other = (BaseEntity)obj;

            //Must have a IS-A relation of types or must be same type
            var typeOfThis = GetType();
            var typeOfOther = other.GetType();
            if (!typeOfThis.GetTypeInfo().IsAssignableFrom(typeOfOther) && !typeOfOther.GetTypeInfo().IsAssignableFrom(typeOfThis))
            {
                return false;
            }

            return Id.Equals(other.Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(BaseEntity left, BaseEntity right)
        {
            if (Equals(left, null))
            {
                return Equals(right, null);
            }

            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(BaseEntity left, BaseEntity right)
        {
            return !(left == right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[{GetType().Name} {Id}]";
        }
    }
}
