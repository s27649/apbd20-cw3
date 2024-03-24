using ConsoleApp1.exceptions;
using ConsoleApp1.interfaces;

namespace ConsoleApp1.containers;

public class GasContainer : Container,IHazardNotifier
{
    public double Pressure { get; set; }
    public GasContainer(double cargoWeight, double height, double conWeight, double depth, 
        string serialNumber, double maxPayload,double pressure) : 
        base(cargoWeight, height, conWeight, depth, serialNumber, maxPayload)
    {
        Pressure = pressure;
    }

    public override void Unload()
    {
        CargoWeight *= 0.95;
    }

    public override void Load(double cargoWeight)
    {
       
        if (cargoWeight + CargoWeight >MaxPayload)
        {
            throw new OverfillException("Masa ładunku przekracza maksymalną pojemność kontenera.");
        } 
        base.Load(cargoWeight);
        CargoWeight += cargoWeight;
    }

    public void OcurrenceSituation(string serialNumber, string message)
    {
        Console.WriteLine($"container{serialNumber}: {message}");
    }

    public override string GetInfo()
    {
        return base.GetInfo()+$"Ciśnienie: {Pressure} atm\n";
    }
}