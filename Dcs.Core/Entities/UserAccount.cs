using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dcs.Core.Entities
{
    public class UserAccount : BaseEntity
    {
        [Column(Order = 2)]
        public string UserName { get; set; }

        [Column(Order = 3)]
        public string DisplayName { get; set; }

        [Column(Order = 4)]
        public string Email { get; set; }

        [Column(Order = 5)]
        public string Phone { get; set; }

        [Column(Order = 1)]
        public string Address { get; set; }
    }
}
