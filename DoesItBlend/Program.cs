using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendables> items = new List<IBlendables>();
            items.Add(new Strawberry());
            items.Add(new Banana());
            items.Add(new Mango());
            items.Add(new IceCubes());
            items.Add(new CellPhone());

            string result = "";
            foreach(dynamic item in items)
            {
                result += item.Blend();    
            }
            Console.WriteLine();
        }
    }
}
