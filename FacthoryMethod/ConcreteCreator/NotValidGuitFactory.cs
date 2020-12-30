using FacthoryMethod.ConcreteProduct;
using FacthoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.ConcreteCreator
{
    public class NotValidGuitFactory : Creator.GuitarFactory
    {
        private int _guitarPrice;
        private int _avgMaintenance;

        public NotValidGuitFactory(int guitarPrice, int avgMaintenance)
        {
            this._guitarPrice = guitarPrice;
            this._avgMaintenance = avgMaintenance;
        }
        public override Guitar SearchGuitar()
        {
            return new NotValidGuitar(_guitarPrice, _avgMaintenance);
        }
    }
}
