using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Pop_EmptyStack_ThrowsInvalidOperationException()
    {
        var stack = new CargoStack<string>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void LIFO_Test()
    {
        var stack = new CargoStack<string>();

        Assert.Equal(0, stack.Count);

        stack.Push("A");
        stack.Push("B");

        Assert.Equal(2, stack.Count);

        string first = stack.Pop();

        Assert.Equal("B", first);
        Assert.Equal(1, stack.Count);

        string second = stack.Pop();
        Assert.Equal("A", second);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Test_Integer()
    {
        var stack = new CargoStack<int>();
        stack.Push(7);

        int first = stack.Pop();

        Assert.Equal(7, first);
        Assert.Equal(0, stack.Count);

    }

    [Fact]
    public void Test_Reuse()
    {
        var stack = new CargoStack<string>();

        stack.Push("A");
        string first = stack.Pop();

        Assert.Equal(0, stack.Count);

        stack.Push("C");
        string second = stack.Pop();

        Assert.Equal("C", second);
        Assert.Equal(0, stack.Count);

    }
}
