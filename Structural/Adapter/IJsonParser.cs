using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface IJsonParser<T>
    {
        T Parse(string data);

        String ConvertToJson(T obj);
    }
}
