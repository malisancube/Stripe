﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Stripe.Models;

namespace Stripe.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StripeCustomerId { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public virtual IList<CreditCard> CreditCards { get; set; }

        public virtual IList<Donation> Donations { get; set; }
        
    }
}