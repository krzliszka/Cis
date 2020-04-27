using System;
namespace zad5
{
    public interface ICarFactory
    {
        ISUV DesignSUV();
        ISedan DesignSedan();
        ICoupe DesignCoupe();
    }
}
