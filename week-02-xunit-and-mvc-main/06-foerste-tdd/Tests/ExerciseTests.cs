using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_PreservesDataAndStartsIncomplete()
    {
        var task = new MissionTask(7, "Sjekk antenne");
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
        Assert.False(task.IsCompleted);
    }

    [Fact]
    public void TaskIsComplete()
    {
        var task = new MissionTask(1, "Sjekk dekk");

        task.Complete();

        Assert.Equal(1, task.Id);
        Assert.Equal("Sjekk dekk", task.Title);
        Assert.True(task.IsCompleted);
    }

    [Fact]
    public void TaskIsComplete_Repeated()
    {
        var task = new MissionTask(7, "Sjekk antenne");

        task.Complete();
        task.Complete();

        Assert.True(task.IsCompleted);
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
    }
}
