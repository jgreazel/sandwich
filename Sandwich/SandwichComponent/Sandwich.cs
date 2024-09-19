namespace SandwichComponent
{
    public class Sandwich
    {
        public int Id { get; set; }
        public bool? PeanutButterApplied { get; set; }
        public bool? JellyApplied { get; set; }
        public bool? Plated { get; set; }
        //public int RequestId { get; set; }
        //public Request Request { get; set; }  // Foreign key to the request
    }

}
