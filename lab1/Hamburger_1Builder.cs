using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Hamburger_1Builder : HamburgerBuilder
    {
        public Hamburger_1Builder() { }

        public override void buildName()
        {
            _hamburger.Name = "Фирменный";
        }

        public override void buildBread()
        {
            _hamburger.Bread = "Белый";
        }

        public override void buildPatty()
        {
            _hamburger.Patty = "Курица";
        }

        public override void buildSauce()
        {
            _hamburger.Sauce = "Сырный";
        }

        public override void buildVegetables()
        {
            _hamburger.Vegetables = "Огурцы";
        }
    }
}
