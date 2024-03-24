using ConsoleApp1;
using ConsoleApp1.containers;
//
// //var container= new Container(12.0) {CargoWeight = 10.0};
// //Console.WriteLine(container.CargoWeight);
//
// //ArrayList
//
// List<int> nub = new List<int>() { 1, 2, 3 };
// List<int> num = new() { 1, 2, 3 };

var container=new LiquidContainer(100,100,300, 200,"KON-L-2",400,true);
container.Load(50);
Console.WriteLine(container.CargoWeight);


var container1=new RefrigeratedContainer(100,100,300, 200,"KON-O-2",400,10);
container1.Load(100,PossibleProducts.Bananas);
Console.WriteLine(container.CargoWeight);

