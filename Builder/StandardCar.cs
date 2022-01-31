using CompositeAndBuilderPattern.CarElements;

namespace CompositeAndBuilderPattern.Builder
{
    public class StandardCar
    {
        public BackParktronics backParktronics { get; set; }
        public Dashboard dashboard { get; set; }
        public Engine engine { get; set; }
        public Roof roof { get; set; }
        public Seats seats { get; set; }
        public TripComputer tripComputer { get; set; }
        public Trunk trunk { get; set; }
        public WheelDrive wheelDrive { get; set; }
    }
}