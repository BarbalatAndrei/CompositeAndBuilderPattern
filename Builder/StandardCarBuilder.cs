using CompositeAndBuilderPattern.CarElements;

namespace CompositeAndBuilderPattern.Builder
{
    public class StandardCarBuilder : IBuilder
    {
        private StandardCar _standardCar { get; set; }
        
        public void reset()
        {
            _standardCar = new StandardCar();
        }
        public BackParktronics setParktonics()
        {
            return this._standardCar.backParktronics = new BackParktronics().setBackParktronics("Sport Parktroniks", 8, 40);
        }

        public Dashboard setDashboard()
        {
            return this._standardCar.dashboard = new Dashboard().setDashboard("Standard Dashboard", 60);
        }

        public Engine setEngine()
        {
            return this._standardCar.engine = new Engine().setEngine("V4", "2.1", 1200);
        }

        public Roof setRoof()
        {
            return this._standardCar.roof = new Roof().setRoof("Half Transparent", "Half", 240);
        }

        public Seats setSeats()
        {
            return this._standardCar.seats = new Seats().setSeats(4,"Alcantra", 140);
        }

        public TripComputer setTripComputer()
        {
            return this._standardCar.tripComputer = new TripComputer().setTripComputer("Pioner", "Standard", 20);
        }

        public Trunk setTrunk()
        {
            return this._standardCar.trunk = new Trunk().setTrunk("Manual", 70);
        }

        public WheelDrive setWheelDrive()
        {
            return this._standardCar.wheelDrive = new WheelDrive().setWheelDrive("Standard WheelDrive", false, 900);
        }        
    }
}