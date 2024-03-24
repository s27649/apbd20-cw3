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
    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight+CargoWeight> MaxPayload)
        {
             throw new OverfillException("Masa ładunku przekracza maksymalną pojemność kontenera.");
        }
    }

    public virtual string GetInfo()
    {
        return "Container:\n" +
               $"Numer Seryjny: {SerialNumber} \n" +
               $"Masa ładunku: {CargoWeight} kg\n" +
               $"Wysokość: {Height} sm\n" +
               $"Waga własna: {ConWeight} kg\n" +
               $"Głębokość: {Depth} sm\n" +
               $"Maksymalna ładowność: {MaxPayload} kg\n";
    }
}