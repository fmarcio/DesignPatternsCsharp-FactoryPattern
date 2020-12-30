using System;
using System.Collections.Generic;
using System.Text;

namespace FacthoryMethod.Creator
{
    public abstract class GuitarFactory
    {
        public abstract Product.Guitar SearchGuitar();
    }
}
