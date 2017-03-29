namespace TestBench.SampleModels
{
    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
