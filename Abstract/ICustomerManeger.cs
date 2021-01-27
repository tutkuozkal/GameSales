using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Entities;

namespace GameSales.Abstract
{
    interface ICustomerManeger
    {
      public void CustomerAdd(Customer customer);
      public void CustomerUpdate(Customer customer);
      public void CustomerDelete(Customer customer);
    }
}
