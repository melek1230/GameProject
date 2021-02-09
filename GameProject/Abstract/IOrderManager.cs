using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderManager
    {
        void OrderAdd(Gamer gamer);
        void OrderDelete(Gamer gamer);
        void OrderUpdate(Gamer gamer);
        void OrderCansel(Gamer gamer);
        void OrderList(Gamer gamer);
    }
}
