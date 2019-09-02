using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dcs.Core.Entities
{
    public class UserAccount : BaseEntity, IBaseEntityBO, IBaseEntityBiz
    {
        [Column(Order = 101)]
        public string UserName { get; set; }

        [Column(Order = 102)]
        public string DisplayName { get; set; }

        [Column(Order = 103)]
        public string Email { get; set; }

        [Column(Order = 104)]
        public string Phone { get; set; }

        [Column(Order = 105)]
        public string Address { get; set; }
    }
}
