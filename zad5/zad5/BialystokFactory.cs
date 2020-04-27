using System;
namespace zad5
{
    public class BialystokFactory : ICarFactory
    {
        public ISUV DesignSUV()
        {
            return new DaciaDuster(60000);
        }


        public ISedan DesignSedan()
        {
            return new DaciaLogan(45000);
        }

        public ICoupe DesignCoupe()
        {
            return new DaciaSandero(40000);
        }
    }
}