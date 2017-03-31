namespace TestBench.SampleModels
{
    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Undefined = 0,
        Male = 1,
        Female = 2
    }
}
