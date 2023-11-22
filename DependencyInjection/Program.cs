// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Car Maruti = new Car(new SuzukiEngine(new Cylinder(new Piston(),new Crankshaft(new Transmitter()))));
Car Toyota = new Car(new ToyotaEngine());

class Car {
    public Car(IEngineVendor suzuki)

    {
        
    }
}

interface IEngineVendor {  }

class SuzukiEngine :IEngineVendor {
    public SuzukiEngine(Cylinder cylinder)
    {
        
    }

}
class ToyotaEngine :IEngineVendor
{

}
class Piston {
  
}
class Cylinder {
    public Cylinder(Piston piston,Crankshaft shaft)
    {
            
    }


}

class Transmitter { }

class Crankshaft {

    public Crankshaft(Transmitter transmitter)
    {
            
    }
}

