namespace TestBench.SampleModels
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName => this.FirstName + " " + this.LastName ;
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Summary => $"{this.FirstName} {this.LastName} ({this.Gender}, {this.Age})";
    }

    public enum Gender
    {
        Undefined = 0,
        Male = 1,
        Female = 2
    }
}
