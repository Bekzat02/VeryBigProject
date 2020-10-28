using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAITUCanteen.Domain.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Owner { get; set; }
        public decimal Money { get; set; }
    }
}
