using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_StartsEmpty()
    {
        var bay = new CargoBay();
        Assert.Equal(0, bay.Count);
    }

    [Fact]
    public void Constructor_OneUnit()
    {
        var bay = new CargoBay();

        bool added = bay.TryAdd("mat");


        Assert.True(added);
        Assert.Equal(1, bay.Count);
    }

    [Fact]
    public void Constuctor_TwoUnits()
    {
        var bay = new CargoBay();

        bool firstAdd = bay.TryAdd("vann");
        bool secondAdd = bay.TryAdd("mat");

        Assert.True(firstAdd);
        Assert.True(secondAdd);
        Assert.Equal(2, bay.Count);
    }

    [Fact]
    public void Constructor_ThreeUnits()
    {
        var bay = new CargoBay();

        bool firstAdd = bay.TryAdd("mat");
        bool secondAdd = bay.TryAdd("vann");
        bool thirdAdd = bay.TryAdd("verktøy");

        Assert.True(firstAdd);
        Assert.True(secondAdd);
        Assert.False(thirdAdd);
        Assert.Equal(2, bay.Count);
    }

    [Fact]
    public void Constructor_TwoCargoBays()
    {
        var bay1 = new CargoBay();
        var bay2 = new CargoBay();

        bool add = bay1.TryAdd("mat");

        Assert.Equal(1, bay1.Count);
        Assert.Equal(0, bay2.Count);
    }
}
