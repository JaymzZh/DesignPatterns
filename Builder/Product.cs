using System;
using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n 产品 创建 ---- ");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
