using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class HamburgerBuilder
    {
        protected Hamburger _hamburger;
        
        public HamburgerBuilder() { }

        public Hamburger getHamburger()
        {
            return _hamburger;
        }

        public void createHamburger()
        {
            _hamburger = new Hamburger();
        }

        public virtual void buildName() { }
        public virtual void buildBread() { }
        public virtual void buildPatty() { }
        public virtual void buildSauce() { }
        public virtual void buildVegetables() { }
    }
}
