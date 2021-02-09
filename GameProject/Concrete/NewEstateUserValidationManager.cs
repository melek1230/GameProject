using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class NewEstateUserValidationManager : IUserValidationService
    {

        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        } 
    }

    
}
