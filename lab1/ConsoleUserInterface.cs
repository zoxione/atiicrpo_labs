

namespace Main
{
    public class ConsoleUserInterface
    {
        Manager _manager = new Manager();
        List<HamburgerBuilder> _builders = new List<HamburgerBuilder>()
        {
            new Hamburger_1Builder(),
            new Hamburger_2Builder(),
            new Hamburger_3Builder(),
        };
        List<Hamburger> _hamburgers = new List<Hamburger>();

        // Структура для хранения пункта меню
        private struct MenuItem
        {
            public MenuItem(string message, Func<bool> dialog)
            {
                Message = message;
                Dialog = dialog;
            }

            // Сообщение для выбора пункта меню
            public string Message { get; set; }

            // Функция с диалогом. Если возвращает true - продолжаем, если false - завершаем работу.
            public Func<bool> Dialog { get; set; }
        }

        // Список пунктов меню.
        private List<MenuItem> _menuItems;

        public ConsoleUserInterface()
        {
            _menuItems = new List<MenuItem>()
            {
                new MenuItem("Выход", ExitDialog),
                new MenuItem("Приготовить", AddHamburger),
                new MenuItem("Готовые гамбургеры", ShowHamburgers),
            };
        }

        // Основной цикл взаимодействия с пользователем
        public void Run()
        {
            while (true)
            {
                try
                {
                    ShowMenuItems();

                    Console.Write("Выберите действие (номер): ");
                    var action = int.Parse(Console.ReadLine());
                    Console.Write("\n");

                    if (!_menuItems[action].Dialog())
                    {
                        // Диалог вернул false - выходим.
                        break;
                    }

                    Console.WriteLine("\n------------------------\n");
                }
                catch (Exception ex)
                {
                    // Исключения логируем и продолжаем работу.
                    Console.WriteLine(ex);
                }
            }
        }

        // Приготовить гамбургер
        private bool AddHamburger()
        {
            Console.WriteLine("Доступные на выбор: Фирменный (1), Биг Крейзи (2) и Мясной Хит (3)");
            Console.Write("Какой приготовить (номер): ");
            int choose = int.Parse(Console.ReadLine());

            switch (choose) 
            {
                case 1: 
                    {
                        _manager.setHamburgerBuilder(_builders[0]);
                        break;
                    }
                case 2:
                    {
                        _manager.setHamburgerBuilder(_builders[1]);
                        break;
                    }
                case 3:
                    {
                        _manager.setHamburgerBuilder(_builders[2]);
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Неверно!");
                        return true;
                    }
            }

            _manager.ConstructHamburger();
            Hamburger hamburger = _manager.getHamburger();
            _hamburgers.Add(hamburger);

            Console.WriteLine("Готово.");
            return true;
        }

        // Вывод всех готовых гамбургеров
        private bool ShowHamburgers()
        {
            Console.WriteLine($"Готовые ({_hamburgers.Count}):");
            
            for (int i = 0; i < _hamburgers.Count; i++)
            {
                if (i != 0) { Console.Write('\n'); }
                _hamburgers[i].showHamburger();
            }

            return true;
        }

        // Вывод пунктов меню на экран
        private void ShowMenuItems()
        {
            // Выводим список команд от 1-й, т.к. 0-й Exit будем выводить последним отдельно.
            for (int i = 1; i < _menuItems.Count; i++)
            {
                Console.WriteLine($"{i}. {_menuItems[i].Message}");
            }

            Console.WriteLine($"{0}. {_menuItems[0].Message}");
        }

        // Завершающий диалог
        private bool ExitDialog()
        {
            Console.WriteLine("Программа завершена!");
            return false;
        }
    }
}