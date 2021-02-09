using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.save(new Gamer { 
                BirthYear=new DateTime(1986,6,23),
                FirstName="MELEK",
                LastName="YILDIZ" ,
                identityNumber="37912425980"
            });
            Console.ReadLine();
        }
    }
}
