using ConsoleApp1.interfaces;
namespace ConsoleApp1.containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsDangerousCargo { get; set; }
    public LiquidContainer(double cargoWeight, double height, double conWeight, 
        double depth, string serialNumber, double maxPayload,bool isDangerousCargo) 
        : base(cargoWeight, height, conWeight, depth, serialNumber, maxPayload)
    {
        IsDangerousCargo = isDangerousCargo;
    }

    public override void Load(double cargoWeight)
    {
     
        if (IsDangerousCargo)
        {
            if (cargoWeight+cargoWeight<MaxPayload*0.5)
            {
                CargoWeight += cargoWeight;
            }
        }
        else
        {
            if (CargoWeight+cargoWeight<MaxPayload*0.9)
            {
                CargoWeight += cargoWeight;
            }
        }  
        base.Load(cargoWeight);
    }

    public override void Unload(double value)
    {
        base.Unload(value);
    }

    public void OcurrenceSituation(string serialNumber)
    {
    }
}