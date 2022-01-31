namespace CompositeAndBuilderPattern.Builder
{
    public class Director
    {
        public IBuilder commandCar(IBuilder builder)
        {
            builder.reset();
            // builder.setEngine();
            // builder.setSeats();
            // builder.setRoof();
            // builder.setDashboard();
            // builder.setParktonics();
            // builder.setTrunk();
            // builder.setTripComputer();
            // builder.setWheelDrive();

            return builder;
        }
    }
}