﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShops.Abstract
{
    public abstract class BaseCustomerManager: ICustomerService
    {
        public virtual void Save(Entities.Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
