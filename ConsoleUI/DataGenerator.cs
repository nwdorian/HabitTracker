using Bogus;
using ConsoleUI.Models;

namespace ConsoleUI;

internal class DataGenerator
{
    internal static List<Habit> GenerateHabitData()
    {
        var faker = new Faker<Habit>()
            .RuleFor(h => h.Date, f => f.Date.Recent(100))
            .RuleFor(h => h.Value, f => f.Random.Number(1, 100));

        var habits = faker.Generate(100);

        return habits;
    }
}
