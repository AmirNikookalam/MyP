using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSP.Domain.Core.Entities
{
    public class Buyer
    {
        #region Properties
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? CardNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime Birthday { get; set; }

        #endregion Properties
    }
}
