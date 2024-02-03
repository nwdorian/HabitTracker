using Bogus;
using ConsoleUI.Models;

namespace ConsoleUI;

internal class DataGenerator
{
    internal static List<Habit> GenerateHabitData()
    {
        Randomizer.Seed = new Random(1337);

        var faker = new Faker<Habit>()
            .RuleFor(h => h.Date, f => f.Date.Recent(200))
            .RuleFor(h => h.Value, f => f.Random.Number(1, 100));

        var habits = faker.Generate(20);

        return habits;
    }
}
