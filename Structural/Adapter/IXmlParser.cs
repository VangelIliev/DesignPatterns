﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface IXmlParser<T>
    {
        T Parse(string data);

        String ConvertToXml(T obj);
    }
}
