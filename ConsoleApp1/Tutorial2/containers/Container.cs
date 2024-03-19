using ConsoleApp1.exceptions;
using ConsoleApp1.interfaces;

namespace ConsoleApp1.containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }

    protected Container(double cargoWeight)
    {
        CargoWeight = cargoWeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        throw new OverfillException();
    }
}