using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp15._07._2022.Fruits
{
    class Orange
    {
        public Orange(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public Orange()
        {

        }

        public string Name { set; get; }

        public int Weight { set; get; }
    }
}
