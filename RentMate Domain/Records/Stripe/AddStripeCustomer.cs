﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMate_Domain.Records.Stripe
{
    public record AddStripeCustomer(
            string Email,
            string Name,
            AddStripeCard CreditCard);
}
