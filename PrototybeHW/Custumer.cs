namespace Prototype
{
    public class Custumer : Proto<Custumer>
    {
        public string FirstName { get; set; }
        public string LaststName { get; set; }

        public Custumer(string firstName, string lastName)
        {
            FirstName = firstName;
            LaststName = lastName;
        }

        public Custumer Clone()
        {
            return new Custumer(this.FirstName, this.LaststName);
        }
    }


}