/*
Требуется реализовать программу, позволяющую создавать гамбургеры из
заданного набора ингридиентов. Рекомендуется использовать паттерн
Строитель. Примеры ингридиентов – Хлеб (Белый, Ржаной), Котлета
(Курица, Свинина, Говядина), Соус (Сырный, Кисло-Сладкий, Сальса),
Овощи (Огурцы, Помидоры). Предусмотреть возможность хранения созданных объектов.
*/

using Main;

var consoleUserInterface = new ConsoleUserInterface();
consoleUserInterface.Run();

/*
Manager manager = new Manager();
List<HamburgerBuilder> builders = new List<HamburgerBuilder>();
List<Hamburger> hamburgers = new List<Hamburger>();

builders.Add(new Hamburger_1Builder());
builders.Add(new Hamburger_2Builder());
builders.Add(new Hamburger_3Builder());

foreach (HamburgerBuilder hb in builders)
{
    manager.setHamburgerBuilder(hb);
    manager.ConstructHamburger();

    Hamburger hamburger = manager.getHamburger();
    hamburgers.Add(hamburger);
}

foreach (Hamburger hamburger in hamburgers)
{
    hamburger.showHamburger();
}
 */

