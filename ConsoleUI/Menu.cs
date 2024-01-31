using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleUI.Models.Enums;

namespace ConsoleUI
{
    internal class Menu
    {
        internal static void MainMenu()
        {
            bool repeatMenu = true;
            while (repeatMenu == true)
            {

                repeatMenu = false;
                Console.Clear();

                var selection = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuSelection>()
                        .Title("Welcome to [green]Habit tracker[/]\nWhat would you like to do?")
                        .PageSize(10)
                        .MoreChoicesText("")
                        .AddChoices(MenuSelection.ViewAllRecords,
                                    MenuSelection.InsertRecord,
                                    MenuSelection.DeleteRecord,
                                    MenuSelection.UpdateRecord,
                                    MenuSelection.CloseApplication)
                                    );

                switch (selection)
                {
                    case MenuSelection.ViewAllRecords:
                        break;
                    case MenuSelection.InsertRecord:
                        break;
                    case MenuSelection.DeleteRecord:
                        break;
                    case MenuSelection.UpdateRecord:
                        break;
                    case MenuSelection.CloseApplication:
                        if (!AnsiConsole.Confirm("Are you sure you want to exit?"))
                        {
                            repeatMenu = true;
                        }
                        else
                        {
                            Console.WriteLine("\nGoodbye!");
                        }
                        break;
                }
            }
        }
    }
}
