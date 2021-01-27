using GameSales.Abstract;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales.Operations
{
    public class CustomerOperations: ICustomerManeger
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Customer Added:" + customer.CustomerId + "  " + customer.CustomerNıckName + "  " + customer.CustomerLastName);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Customer Delete:" + customer.CustomerId + "  " + customer.CustomerNıckName + "  " + customer.CustomerLastName);
        }

        public void CustomerUpdate(Customer customer)
        {
            Console.WriteLine("Customer Update:" + customer.CustomerId + "  " + customer.CustomerNıckName + "  " + customer.CustomerLastName);
        }

      
        }
    }
}
