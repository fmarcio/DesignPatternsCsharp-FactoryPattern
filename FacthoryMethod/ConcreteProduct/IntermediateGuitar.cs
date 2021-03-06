﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.ConcreteProduct
{
    public class IntermediateGuitar : Product.Guitar
    {
        private readonly string _guitarModel;
        private int _guitarPrice;
        private int _avgMaintenancePrice;

        public IntermediateGuitar(int guitarPrice, int avgMaintenancePrice)
        {
            this._guitarModel = "Epiphone Les Paul";
            this._guitarPrice = guitarPrice;
            this._avgMaintenancePrice = avgMaintenancePrice;
        }

        //implement properties from abstract class
        public override string GuitarModel
        {
            get { return _guitarModel; }
        }

        public override int GuitarPrice
        {
            get { return _guitarPrice; }
            set { _guitarPrice = value; }
        }
        public override int AvgMaintenancePrice
        {
            get { return _avgMaintenancePrice; }
            set { _avgMaintenancePrice = value; }
        }

    }
}
