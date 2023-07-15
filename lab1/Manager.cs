using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Manager
    {
        private HamburgerBuilder _hamburgerBuilder;
        
        public Manager() { }

        public void setHamburgerBuilder(HamburgerBuilder hb)
        {
            _hamburgerBuilder = hb;
        }

        public void ConstructHamburger()
        {
            // создаем -> имя -> хлеб -> котлета -> соус -> овощи
            _hamburgerBuilder.createHamburger();
            _hamburgerBuilder.buildName();
            _hamburgerBuilder.buildBread();
            _hamburgerBuilder.buildPatty();
            _hamburgerBuilder.buildSauce();
            _hamburgerBuilder.buildVegetables();
        }

        public Hamburger getHamburger()
        {
            return _hamburgerBuilder.getHamburger();
        }
    }
}
