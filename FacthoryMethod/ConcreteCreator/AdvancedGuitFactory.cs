using FacthoryMethod.ConcreteProduct;
using FacthoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.ConcreteCreator
{
    public class AdvancedGuitFactory : Creator.GuitarFactory
    {
        private int _guitarPrice;
        private int _avgMaintenance;

        public AdvancedGuitFactory(int guitarPrice, int avgMaintenance)
        {
            this._guitarPrice = guitarPrice;
            this._avgMaintenance = avgMaintenance;
        }

        public override Guitar SearchGuitar()
        {
            return new AdvancedGuitar(_guitarPrice, _avgMaintenance);
        }

    }
}
