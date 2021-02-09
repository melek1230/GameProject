using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager:BaseCustomerManager
    {
        IUserValidationService _userValidation;
        public GamerManager(IUserValidationService userValidation)
        {
            _userValidation = userValidation;

        }
        public override void save(Gamer gamer)
        {
            if(_userValidation.CheckIfRealPerson(gamer))
            { 
                base.save(gamer);
            }
            else
            {
                throw new Exception("not a valid Gamer");
            }
           
        }

    }
}
