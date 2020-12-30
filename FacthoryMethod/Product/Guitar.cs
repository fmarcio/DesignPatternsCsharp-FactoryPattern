using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.Product
{
    public abstract class Guitar
    {   
        //set class properties
        public abstract string GuitarModel { get; }
        public abstract int GuitarPrice { get; set; }
        public abstract int AvgMaintenancePrice { get; set; }
    }
}
