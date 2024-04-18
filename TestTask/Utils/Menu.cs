using System;
using TestTask.Utils;

namespace TestTask
{
    static class Menu
    {
        const string menuItemOne = "Вывести все паллеты отсортированные по возрастанию срока годности, в каждой группе отсортированные паллеты по весу";
        const string menuItemTwo = "Вывести 3 паллеты, которые содержат коробки с наибольшим сроком годности, отсортированные по возрастанию объема";
        const string exit = "Выход";
        const string cursor = ">>";
        const string noCursor = "  ";
        const string Continuation = "Нажмите любую клавишу для продолжения...";
        public static void Start()
        {
            string[] menuItems = { menuItemOne, menuItemTwo, exit };
            int selectedIndex = 0;
            Pallets[] parents = ReadJson.ReadPallets();
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(cursor);
                    }
                    else
                    {
                        Console.Write(noCursor);
                    }

                    Console.WriteLine(menuItems[i]);
                    Console.ResetColor();
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(menuItems.Length - 1, selectedIndex + 1);
                        break;
                    case ConsoleKey.Enter:
                        switch (selectedIndex)
                        {
                            case 0:
                                Sorting.Sort(parents);
                                for (int i = 0; i < parents.Length; i++)
                                {
                                    parents[i].Writ();
                                }
                                break;
                            case 1:
                                Sorting.SortEnd(parents);
                                for (int i = parents.Length - 3; i < parents.Length; i++)
                                {
                                    parents[i].Writ();
                                }
                                break;
                            case 2:
                                return;
                        }
                        Console.WriteLine(Continuation);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
