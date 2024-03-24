
using ConsoleApp1.interfaces;

namespace ConsoleApp1.containers;

public class RefrigeratedContainer: Container,IHazardNotifier
{
    Dictionary<PossibleProducts, double> Products = new Dictionary<PossibleProducts, double>()
    {
        { PossibleProducts.Bananas, 13.3 },
        { PossibleProducts.Chocolate,18},
        { PossibleProducts.Fish , 2 },
        { PossibleProducts.Meat , -15 },
        { PossibleProducts.Icecream , -18 },
        { PossibleProducts.Frozenpizza, -30 },
        { PossibleProducts.Cheese ,7.2 },
        { PossibleProducts.Sausages, 5 },
        { PossibleProducts.Butter ,20.5 },
        { PossibleProducts.Eggs,19 }
        
    };
    public double Temperature { get; set; }
    
    public RefrigeratedContainer(double cargoWeight, double height, double conWeight, double depth, 
        string serialNumber, double maxPayload, double temperature)
        : base(cargoWeight, height, conWeight, depth, serialNumber, maxPayload)
    {
        Temperature = temperature;
    }

    public new void Load(double cargoWeight,PossibleProducts product)
    {
        base.Load(cargoWeight);
        if (product !=null)
        {
            OcurrenceSituation("prod");
        }

        double prodTemp = Products[product];
        if (Temperature < prodTemp)
        {
            OcurrenceSituation("temp");
        }
    }

    public override void Unload(double value)
    {
        base.Unload(value);
    }

    public void OcurrenceSituation(string serialNumber)
    {
        
    }
}