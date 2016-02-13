using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Framework.Warming.Model.Modelo
{
    public class Products : Product
    {
        public string MyProperty { get { return this.ListPrice.ToString(); } }
        public int Antiquity { get { return ((int)((DateTime.Now - this.SellStartDate).TotalDays)); } }
    }
}


