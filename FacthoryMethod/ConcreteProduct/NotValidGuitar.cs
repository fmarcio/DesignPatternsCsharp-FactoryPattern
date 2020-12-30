using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.ConcreteProduct
{
    public class NotValidGuitar : Product.Guitar
    {
        private readonly string _guitarModel;
        private int _guitarPrice;
        private int _avgMaintenancePrice;

        public NotValidGuitar(int guitarPrice, int avgMaintenancePrice)
        {
            this._guitarModel = "Modelo inválido. Favor escolher com base nas opções apresentadas.";
            this._guitarPrice = guitarPrice;
            this._avgMaintenancePrice = avgMaintenancePrice;
        }

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
