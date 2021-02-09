using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.identityNumber), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),gamer.BirthYear.Year);
        }
    }
}
