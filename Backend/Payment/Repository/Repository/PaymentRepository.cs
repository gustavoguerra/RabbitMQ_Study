using Domain.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class PaymentRepository : Repository<PaymentDomain>, IPaymentRepository
    {
        
    }
}
