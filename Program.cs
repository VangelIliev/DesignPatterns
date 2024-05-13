using DesignPatterns.Creational;
using System.Text;


var prototype = new Prototype(new Address(15, "Bratq Miladinovi 16"), "Test");

var copy = ExtensionMethods.DeepCopyJSON(prototype);

Console.WriteLine(prototype.Address.StreetNumber);
Console.WriteLine(copy.Address.StreetNumber);

copy.Address.StreetNumber = 16;

Console.WriteLine(prototype.Address.StreetNumber);
Console.WriteLine(copy.Address.StreetNumber);