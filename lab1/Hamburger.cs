using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Hamburger
    {
        public string Name { get; set; } = "";
        public string Bread { get; set; } = "";
        public string Patty { get; set; } = "";
        public string Sauce { get; set; } = "";
        public string Vegetables { get; set; } = "";

        public Hamburger() { }

        public void showHamburger()
        {
            Console.WriteLine($"{Name}\nХлеб: {Bread}\nКотлета: {Patty}\nСоус: {Sauce}\nОвощи: {Vegetables}");
        }
    }
}
