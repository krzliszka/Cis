using System;
namespace zad5
{
    public class WarsawFactory : ICarFactory
    {
        public ISUV DesignSUV()
        {
            return new TeslaX(500000);
        }

        public ISedan DesignSedan()
        {
            return new TeslaS(400000);
        }

        public ICoupe DesignCoupe()
        {
            return new Tesla3(150000);
        }
    }
}
