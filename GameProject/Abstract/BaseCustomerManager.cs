using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager : IGamerService
    {
        public virtual void save(Gamer gamer)
        {
            Console.WriteLine("SAVE TO DB" +gamer.FirstName);
        }

       
    }
}
