﻿using FacthoryMethod.ConcreteProduct;
using FacthoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.ConcreteCreator
{
    public class BasicGuitFactory : Creator.GuitarFactory
    {
        private int _guitarPrice;
        private int _avgMaintenance;

        public BasicGuitFactory(int guitarPrice, int avgMaintenance)
        {
            this._guitarPrice = guitarPrice;
            this._avgMaintenance = avgMaintenance;
        }

        public override Guitar SearchGuitar()
        {
            return new BasicGuitar(_guitarPrice, _avgMaintenance);
        }
    }
}
