using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PaymentDomain : Entity
    {        
        public string Name { get; set; }
        public string NunberCredcard { get; set; }
        public string DatePayment { get; set; }
        public string StatusPayment { get; set; }
    }
}
