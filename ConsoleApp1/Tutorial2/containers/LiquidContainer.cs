using ConsoleApp1.interfaces;
namespace ConsoleApp1.containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsDangerousCargo { get; set; }
    private int next = 1;
    public LiquidContainer(double cargoWeight, double height, double conWeight, 
        double depth, string serialNumber, double maxPayload,bool isDangerousCargo) 
        : base(cargoWeight, height, conWeight, depth, serialNumber, maxPayload)
    {
        IsDangerousCargo = isDangerousCargo;
    }

    public override void Load(double cargoWeight)
    {
        double LoadPercent = IsDangerousCargo ? 0.5 : 0.9;
        double Load = MaxPayload * LoadPercent;
        
        if (CargoWeight + cargoWeight > Load)
        {
            
            OcurrenceSituation(SerialNumber,"Próbowano przekroczyć maksymalną ładowność.");
        } 
       
        CargoWeight += cargoWeight; 
        base.Load(cargoWeight);
    }

    public override void Unload()
    {
        base.Unload();
    }
    
    public void OcurrenceSituation(string serialNumber,string message)
    {
        Console.WriteLine($"container {serialNumber}: {message}");
    }

    public override string GetInfo()
    {
        return base.GetInfo()+$"Ładunek niebiezpieczny: {IsDangerousCargo}\n";
    }
}