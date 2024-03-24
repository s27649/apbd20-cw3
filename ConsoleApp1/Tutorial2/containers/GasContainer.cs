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

    public override void Unload(double value)
    {
        base.Unload(value);
        CargoWeight *= 0.05f;
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        if (cargoWeight + CargoWeight > 0.95 * MaxPayload)
        {
            OcurrenceSituation(SerialNumber); 
        }
    }

    public void OcurrenceSituation(string serialNumber)
    {
        throw new NotImplementedException();
    }
}