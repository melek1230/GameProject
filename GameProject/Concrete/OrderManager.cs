using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderManager
    {
        private IProduct _product;
        public OrderManager(IProduct companyproduct)
        {
            _product = companyproduct;


        }
        public void OrderAdd(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void OrderCansel(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void OrderDelete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void OrderList(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void OrderUpdate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
