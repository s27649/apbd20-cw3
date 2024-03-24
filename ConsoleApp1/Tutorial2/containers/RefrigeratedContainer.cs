
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
        string serialNumber, double maxPayload, double temperature,PossibleProducts products)
        : base(cargoWeight, height, conWeight, depth, serialNumber, maxPayload)
    {
        Temperature = temperature;
    }

    public new void Load(double cargoWeight,PossibleProducts product)
    {
        
        if (Products.ContainsKey(product))
        {
            OcurrenceSituation(SerialNumber,"Nie można załadować produktu innego typu do tego kontenera.");
            
        }

        double prodTemp = Products[product];
        if (Temperature < prodTemp)
        {
            OcurrenceSituation(SerialNumber,"Temperatura pojemnika jest zbyt niska dla załadowanego produktu.");
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
        Console.WriteLine($"container{serialNumber}: {message}");
    }

    public override string GetInfo()
    {
        return base.GetInfo();
    }
}