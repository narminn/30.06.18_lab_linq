using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Entity
    {
        public static List<Products> products = new List<Products>()
        {
            new Products{ProoductName="Pencil",Price=2,StockCount=100},
            new Products{ProoductName="Pen",Price=1,StockCount=140},
            new Products{ProoductName="Book",Price=5,StockCount=24},
            new Products{ProoductName="Notebook",Price=4,StockCount=68},
            new Products{ProoductName="Ruler",Price=2,StockCount=120},
            new Products{ProoductName="Toy",Price=12,StockCount=32},
            new Products{ProoductName="Pen",Price=3,StockCount=145},
            new Products{ProoductName="Book",Price=10,StockCount=90},
            new Products{ProoductName="Pen",Price=1,StockCount=125},
            new Products{ProoductName="Toy",Price=15,StockCount=77},
            new Products{ProoductName="Ruler",Price=6,StockCount=40},
            new Products{ProoductName="Book",Price=17,StockCount=16},



        };
    }
}
