using ConsoleApp1.exceptions;
using ConsoleApp1.interfaces;

namespace ConsoleApp1.containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    
    public double Height { get; set; }
    
    public double ConWeight { get; set; }
    
    public double Depth { get; set; }
    
    public string SerialNumber { get; set; }
    
    public double MaxPayload { get; set; }

    protected Container(double cargoWeight, double height, double conWeight, double depth, 
        string serialNumber,double maxPayload)
    {
        CargoWeight = cargoWeight;
        Height = height;
        ConWeight = conWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxPayload = maxPayload;
    }
    public virtual void Unload(double value)
    {
        CargoWeight -= value;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight+CargoWeight> MaxPayload)
        {
             throw new OverfillException();
        }
       
    }
}