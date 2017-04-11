namespace TestBench.SampleModels
{
    using System.Collections.Generic;

    public class Person
    {
        private readonly IList<Address> _addresses = new List<Address>();

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int Age { get; set; }
        public Gender Gender { get; set; }
        public bool IsVegetarian { get; set; }

        public IList<Address> Addresses => _addresses;

        public string FullName => this.FirstName + " " + this.LastName;
        public string Summary => $"{this.FirstName} {this.LastName} ({this.Gender}, {this.Age})";
    }

    public enum Gender
    {
        Undefined = 0,
        Male = 1,
        Female = 2
    }
}
