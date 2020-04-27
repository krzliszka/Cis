using System;
namespace zad5
{
    public class CracowFactory : ICarFactory
    {
        public ISUV DesignSUV()
        {
            return new BMWx5(300000);
        }

        public ISedan DesignSedan()
        {
            return new BMWseries5(250000);
        }

        public ICoupe DesignCoupe()
        {
            return new BMWseries4(280000);
        }
    }
}
