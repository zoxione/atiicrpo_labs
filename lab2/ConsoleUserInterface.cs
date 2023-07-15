

namespace Main
{
    public class ConsoleUserInterface
    {

        private struct TextItem 
        {
            public string Disconnect { get; set; }
            public string ShowSchedule { get; set; }
            public string ShowStadiums { get; set; }
            public string AskAQuestion { get; set; }
            public string EnterYourQuestion { get; set; }
            public string SelectAnAction { get; set; }

            public TextItem(string s1, string s2, string s3, string s4, string s5, string s6) 
            {
                Disconnect = s1;
                ShowSchedule = s2;
                ShowStadiums = s3;
                AskAQuestion = s4;
                EnterYourQuestion = s5;
                SelectAnAction = s6;
            }
        }
        List<TextItem> _consoleText = new List<TextItem>()
        {
           new TextItem("Disconnect", "Show schedule", "Show stadiums", "Ask a question", "Enter your question: ", "Select an action (number): "),
           new TextItem("Отключиться", "Показать расписание", "Показать стадионы", "Задать вопрос", "Укажите ваш вопрос: ", "Выберите действие (номер): "),
           new TextItem("Abmelden", "Zeige Zeitplan", "Zeige Stadien", "Eine Frage stellen", "Geben Sie Ihre Frage ein: ", "Wählen Sie eine Aktion (Nummer): ")
        };

        List<CommunicationCenter> _communicationCenters = new List<CommunicationCenter>()
        {
            new EngCommunicationCenter(),
            new RusAdapter(),
            new DeuAdapter(),
        };

        int LANG = 0;

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

        public ConsoleUserInterface() {}

        // Основной цикл взаимодействия с пользователем
        public void Run()
        {
            Console.WriteLine("1. English");
            Console.WriteLine("2. Russian ");
            Console.WriteLine("3. German");
            Console.Write("Choose language: ");
            LANG = int.Parse(Console.ReadLine());

            if (LANG == 1 || LANG == 2 || LANG == 3)
            {
                LANG -= 1;
                _communicationCenters[LANG].Welcome();

                _menuItems = new List<MenuItem>()
                {
                    new MenuItem(_consoleText[LANG].Disconnect, ExitDialog),
                    new MenuItem(_consoleText[LANG].ShowSchedule, ConsoleShowSchedule),
                    new MenuItem(_consoleText[LANG].ShowStadiums, ConsoleShowStadiums),
                    new MenuItem(_consoleText[LANG].AskAQuestion, ConsoleQuestionFan),
                };
            }
            else
            {
                Console.WriteLine("Language is incorrect");
                return;
            }

            while (true)
            {
                try
                {
                    ShowMenuItems();

                    Console.Write(_consoleText[LANG].SelectAnAction);
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
        private bool ConsoleShowSchedule()
        {
            _communicationCenters[LANG].ShowSchedule();
            return true;
        }

        private bool ConsoleShowStadiums()
        {
            _communicationCenters[LANG].ShowStadiums();
            return true;
        }

        private bool ConsoleQuestionFan()
        {
            Console.Write(_consoleText[LANG].EnterYourQuestion);
            string message = Console.ReadLine();
            _communicationCenters[LANG].QuestionFan(message);
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
            _communicationCenters[LANG].Goodbye();
            return false;
        }
    }
}