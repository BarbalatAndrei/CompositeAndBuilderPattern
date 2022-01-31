using System;
using CompositeAndBuilderPattern.Builder;
using CompositeAndBuilderPattern.CarElements;
using CompositeAndBuilderPattern.CompositePattern;

namespace CompositeAndBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            SportCarBuilder typeCarBuilder = new SportCarBuilder();
            //StandardCarBuilder typeCarBuilder = new StandardCarBuilder();
            director.commandCar(typeCarBuilder);
            
            //front part
            Composite frontPart = new Composite();
            Engine engine = typeCarBuilder.setEngine();
            frontPart.addElement(engine);
            
            //back part
            Composite backPart = new Composite();
            Trunk trunk = typeCarBuilder.setTrunk();
            BackParktronics backParktronics = typeCarBuilder.setParktonics();
            backPart.addElement(trunk);
            backPart.addElement(backParktronics);
            
            //interior part composites
            Composite interiorPart = new Composite();
            Composite salonPart = new Composite();
            Composite electronicPart = new Composite();
            
            //interior salon
            Seats seats = typeCarBuilder.setSeats();
            Roof roof = typeCarBuilder.setRoof();
            salonPart.addElement(seats);
            salonPart.addElement(roof);
            
            //interior electronic
            TripComputer tripComputer = typeCarBuilder.setTripComputer();
            electronicPart.addElement(tripComputer);
            
            //add interior composites
            interiorPart.addElement(salonPart);
            interiorPart.addElement(electronicPart);
            
            //below part
            Composite belowPart = new Composite();
            WheelDrive wheelDrive = typeCarBuilder.setWheelDrive();
            belowPart.addElement(wheelDrive);
            
            //component
            Composite carComposite = new Composite();
            carComposite.addElement(belowPart);
            carComposite.addElement(frontPart);
            carComposite.addElement(interiorPart);
            carComposite.addElement(backPart);
            Console.WriteLine("\nCar Info\n");
            carComposite.showElementDetail();
            Console.WriteLine("\nTotal Price: {0}",carComposite.getElementPrice());
        }
    }
}