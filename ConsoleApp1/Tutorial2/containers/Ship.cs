using ConsoleApp1.exceptions;

namespace ConsoleApp1.containers;

public class Ship
{
    private List<Container> _containers = new List<Container>();
    public double MaxSpeed { get; set; }
    public int MaximumContainers { get; set; }
    public double MaxWeight { get; set; }

    public Ship(double maxSpeed, int maximumContainers, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaximumContainers = maximumContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (_containers.Count<MaximumContainers && GetWeight()+container.CargoWeight<=MaxWeight*1000)
        {
           _containers.Add(container); 
           Console.WriteLine($"Container {container.SerialNumber} był dodany");
        }
        else
        {
            throw new OverfillException("Nie można załadować kontenera na statek." +
                                        " Przekroczono limity statku.");
        }
    }

    public void LoadContainers(List<Container> containers)
    {
        foreach (var container in containers)
        {
            LoadContainer(container);
        }
    }

    public void UnloadContainer(Container container)
    {
        _containers.Remove(container);
    }

    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        for (int i=0; i<_containers.Count; i++)
        {
            if (_containers[i].SerialNumber==serialNumber)
            {
                _containers[i] = newContainer;
                return;
            }
            else
            {
                throw new OverfillException($"Na statku nie znaleziono kontenera o numerze {serialNumber}.");
            }
        }
        Console.WriteLine($"Container {newContainer.SerialNumber} był przeniesiony");
        
    }

    public void Transfer(Container container, Ship ship)
    {
        if (ship.GetWeight()+container.CargoWeight>ship.MaxWeight*1000)
        {
            throw new OverfillException("Nie można przenieść kontenera. Przekroczono limit wagi docelowego statku.");
        }
        ship.LoadContainer(container);
        UnloadContainer(container);
        Console.WriteLine($"Container {container.SerialNumber} był przeniesiony");
    }

    public double GetWeight()
    {
        double total = 0;
        foreach (var container in _containers)
        {
            total += container.CargoWeight;
        }

        return total;
    }

    public string Info()
    {
        return $"Statek:\n+" +
               $"Iłosc kontenerów: {MaximumContainers}\n"+
               $"Maksymalna prędkość:{MaxSpeed} w\n"+
               $"Maksymalna waga wszystkich kontenerów:{MaxWeight} t\n";
    }
        
    
    
}