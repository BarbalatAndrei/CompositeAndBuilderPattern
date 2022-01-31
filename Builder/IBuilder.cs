using CompositeAndBuilderPattern.CarElements;

namespace CompositeAndBuilderPattern.Builder
{
    public interface IBuilder
    {
        void reset();
        BackParktronics setParktonics();
        Dashboard setDashboard();
        Engine setEngine();
        Roof setRoof();
        Seats setSeats();
        TripComputer setTripComputer();
        Trunk setTrunk();
        WheelDrive setWheelDrive();
    }
}