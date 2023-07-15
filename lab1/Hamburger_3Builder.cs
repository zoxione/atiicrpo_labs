using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Hamburger_3Builder : HamburgerBuilder
    {
        public Hamburger_3Builder() { }

        public override void buildName()
        {
            _hamburger.Name = "Мясной Хит";
        }

        public override void buildBread()
        {
            _hamburger.Bread = "Ржаной";
        }

        public override void buildPatty()
        {
            _hamburger.Patty = "Говядина";
        }

        public override void buildSauce()
        {
            _hamburger.Sauce = "Сальса";
        }

        public override void buildVegetables()
        {
            _hamburger.Vegetables = "Помидоры";
        }
    }
}
