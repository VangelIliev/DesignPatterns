using DesignPatterns.Creational;
using System.Text;


var computer = new Computer();
computer.CPU = "12";

var secondComputer = new Computer();
secondComputer.CPU = "13";

secondComputer = computer;

computer.CPU = "13";
Console.WriteLine(computer.CPU);
Console.WriteLine(secondComputer.CPU);