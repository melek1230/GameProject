using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICompanyManager
    {
        public void Add(IProduct product);        
        public void Delete(IProduct product);
        public void Update(IProduct product);
    }
}
