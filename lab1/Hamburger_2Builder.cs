using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Hamburger_2Builder : HamburgerBuilder
    {
        public Hamburger_2Builder() { }

        public override void buildName()
        {
            _hamburger.Name = "Биг Крейзи";
        }

        public override void buildBread()
        {
            _hamburger.Bread = "Ржаной";
        }

        public override void buildPatty()
        {
            _hamburger.Patty = "Свинина";
        }

        public override void buildSauce()
        {
            _hamburger.Sauce = "Кисло-Сладкий";
        }

        public override void buildVegetables()
        {
            _hamburger.Vegetables = "Помидоры";
        }
    }
}
