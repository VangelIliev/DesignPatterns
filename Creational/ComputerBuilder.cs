using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Creational.ComputerDirector;

namespace DesignPatterns.Creational
{
    public class ComputerBuilder
{
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }
        public ComputerBuilder AddCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }
    public ComputerBuilder AddRAM(string ram)
    {
        _computer.RAM = ram;
        return this;
    }
    public ComputerBuilder AddHardDisk(string hardDisk)
    {
        _computer.HardDisk = hardDisk;
        return this;
    }
    public Computer Build()
    {
        return _computer;
    }
}

    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HardDisk { get; set; }
    }
    /*Optional you can have a class Director which will tell the exact order how to build Objects*/
   public class ComputerDirector
{
    public Computer Construct(ComputerBuilder builder)
    {
        return builder.AddCPU("Intel i7")
                      .AddRAM("16GB")
                      .AddHardDisk("1TB HDD")
                      .Build();
    }
}

}
