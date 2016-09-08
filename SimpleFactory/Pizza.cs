using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.Write("Prepare Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box Pizza");
        }
    }
}
