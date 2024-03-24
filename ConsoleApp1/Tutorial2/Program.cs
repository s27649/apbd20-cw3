using ConsoleApp1.containers;


var container = new LiquidContainer(100, 300, 300, 200, "KON-L-1", 700, true);
Console.WriteLine(container.GetInfo());
var container1 = new GasContainer(120, 400, 350, 200, "KON-G-1", 600, 100);
Console.WriteLine(container1.GetInfo());
var container2 = new RefrigeratedContainer(190,400,400,200,"KON-C-1", 700,12,PossibleProducts.Bananas);
Console.WriteLine(container2.GetInfo());
var container3 = new LiquidContainer(300, 300, 600, 200, "KON-L-2", 800, true);
Console.WriteLine(container3.GetInfo());
container.Load(50);
Console.WriteLine(container.GetInfo());
container3.Load(50);
Console.WriteLine(container3.GetInfo());
container3.Unload();
Console.WriteLine(container3.GetInfo());



Ship ship = new Ship(200, 3, 30);
Console.WriteLine(ship.Info());
ship.LoadContainer(container);
ship.LoadContainer(container1);
ship.ReplaceContainer(container.SerialNumber,container2);

Ship ship1 = new Ship(200, 4, 20); 
ship.Transfer(container2,ship1);
