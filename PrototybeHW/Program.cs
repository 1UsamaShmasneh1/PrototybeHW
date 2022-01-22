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
}