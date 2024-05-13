using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    //Used in real world applications
    public static class ExtensionMethods
    {
        public static T DeepCopyJSON<T>(T input)
        {
            var jsonString = JsonSerializer.Serialize(input);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }

    //Used in previous project example .net Framework 4.7.1

    //public static T DeepClone<T>(T obj)
    //{
    //    using (var ms = new System.IO.MemoryStream())
    //    {
    //        var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
    //        formatter.Serialize(ms, obj);
    //        ms.Position = 0;

    //        return (T)formatter.Deserialize(ms);
    //    }
    //}


    //Implementation using IClonable
    public class Address : ICloneable
    {
        public Address()
        {

        }
        public int StreetNumber { get; set; }

        public string StreetName { get; set; }

        public Address(int stringNumber, string streetName)
        {
            this.StreetNumber = stringNumber;
            this.StreetName = streetName;
        }

        public object Clone()
        {
            return new Address(StreetNumber, StreetName);
        }
    }
    [Serializable]
    internal class Prototype : ICloneable
    {
        public Prototype()
        {

        }
        public Prototype(Address address, string name)
        {
            this.Address = address;
            this.Name = name;
        }
        public Address Address { get; set; }

        public string Name { get; set; }

        public object Clone()
        {
            return new Prototype((Address)Address.Clone(), this.Name);
        }
    }
}
