using System;
using System.Collections.Generic;
using System.Text;

namespace Dcs.Core.Entities
{
    interface IBaseEntityBiz
    {
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
    }
}
