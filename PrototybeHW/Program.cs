using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static T DeepCopy<T>(T self)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(self);
            T obj = System.Text.Json.JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }

    public interface Proto<T>
    {
        T Clone();
    }

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

    [Serializable]
    class Invoice : Proto<Invoice>
    {
        public Custumer Custumer { get; set; }
        public double TotalToPay { get; set; }

        public Invoice Clone()
        {
            return new Invoice(this.Custumer.Clone(), this.TotalToPay);
        }

        public Invoice(Custumer custumer, double totalToPay)
        {
            Custumer = custumer.Clone();
            TotalToPay = totalToPay;
        }
    }


}