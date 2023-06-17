using System;

namespace ReizTech_InternExam;

internal static class InternExam {
    private static int _selectedOption = 1;

    private static void Main() {
        Console.CursorVisible = false;

        while(true) {
            Console.Clear();
            DisplayOptions();

            var keyInfo = Console.ReadKey(true);

            switch(keyInfo.Key) {
                case ConsoleKey.UpArrow:
                    _selectedOption = Math.Max(_selectedOption - 1, 1);
                    break;

                case ConsoleKey.DownArrow:
                    _selectedOption = Math.Min(_selectedOption + 1, 2);
                    break;

                case ConsoleKey.Enter:
                    ExecuteSelectedMethod();
                    break;

                case ConsoleKey.Backspace:
                    return;
            }
        }
    }

    private static void DisplayOptions() {
        Console.WriteLine("Press |↑| or |↓| to navigate the menu.");
        Console.WriteLine("Press |Enter| to select an option.");
        Console.WriteLine("Press |Backspace| to exit the program.");
        Console.WriteLine("============================");
        Console.WriteLine("Reiz Tech Intern Examination");
        Console.WriteLine("============================");
        Console.WriteLine("Select an option:");
        Console.WriteLine(_selectedOption == 1 ? "-> Problem 1" : "   Problem 1");
        Console.WriteLine(_selectedOption == 2 ? "-> Problem 2" : "   Problem 2");
    }

    private static void ExecuteSelectedMethod() {
        Console.Clear();
        InternExamProblems problems = new();

        switch(_selectedOption) {
            case 1:
                problems.Problem1();
                break;

            case 2:
                problems.Problem2();
                break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}