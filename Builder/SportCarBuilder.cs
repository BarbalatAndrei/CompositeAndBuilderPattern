using CompositeAndBuilderPattern.CarElements;

namespace CompositeAndBuilderPattern.Builder
{
    public class SportCarBuilder : IBuilder
    {
        private SportCar _sportCar { get; set; }
        public void reset()
        {
            this._sportCar = new SportCar();
        }
        public BackParktronics setParktonics()
        {
            return this._sportCar.backParktronics = new BackParktronics().setBackParktronics("Sport Parktroniks", 8, 80);
        }
        public Dashboard setDashboard()
        {
            return this._sportCar.dashboard = new Dashboard().setDashboard("Sport Dashboard", 80);
        }
        public Engine setEngine()
        {
            return this._sportCar.engine = new Engine().setEngine("V8", "3.5", 1800);
        }
        public Roof setRoof()
        {
            return this._sportCar.roof = new Roof().setRoof("Full Transparent", "full", 340);
        }
        public Seats setSeats()
        {
            return this._sportCar.seats = new Seats().setSeats(4,"Alcantra", 200);
        }
        public TripComputer setTripComputer()
        {
            return this._sportCar.tripComputer = new TripComputer().setTripComputer("Pioner", "Digital", 45);
        }
        public Trunk setTrunk()
        {
            return this._sportCar.trunk = new Trunk().setTrunk("Electric", 120);
        }
        public WheelDrive setWheelDrive()
        {
            return this._sportCar.wheelDrive = new WheelDrive().setWheelDrive("Sport WheelDrive", true, 1300);
        }
    }
}