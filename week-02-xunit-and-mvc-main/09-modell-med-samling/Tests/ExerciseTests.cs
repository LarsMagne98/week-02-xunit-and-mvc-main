using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Add_TwoTasks_AssignsIdsAndStoresTitles()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        Assert.Equal(1, first.Id);
        Assert.Equal(2, second.Id);
        Assert.Equal("Sjekk antenne", first.Title);
        Assert.Equal("Lad rover", second.Title);
        Assert.Equal(2, board.Count);
        Assert.False(first.IsCompleted);
        Assert.False(second.IsCompleted);
    }

    [Fact]
    public void Complete_KnownId_CompletesOnlySelectedTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        bool result = board.Complete(second.Id);
        Assert.True(result);
        Assert.False(first.IsCompleted);
        Assert.True(second.IsCompleted);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void Complete_UnknownId_DoesNotChangeTasks()
    {
        var board = new MissionBoard();
        var task = board.Add("Lad rover");
        Assert.False(board.Complete(99));
        Assert.False(task.IsCompleted);
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void GetAll_ReturnsCollectionCopy()
    {
        var board = new MissionBoard();
        board.Add("Lad rover");
        var copy = board.GetAll();
        copy.Clear();
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void Empty_Board()
    {
        var board = new MissionBoard();
        var copy = board.GetAll();

        Assert.Equal(0, board.Count);
        Assert.Empty(copy);
    }

    [Fact]
    public void CanReComplete()
    {
        var board = new MissionBoard();
        var item = board.Add("Sjekk");

        bool first = board.Complete(1);
        bool second = board.Complete(1);

        Assert.True(first);
        Assert.True(second);
        Assert.True(item.IsCompleted);
        Assert.Equal(1, board.Count);

    }

    [Fact]
    public void IndependentBoards()
    {
        var board = new MissionBoard();
        var task = new MissionBoard();

        var item = board.Add("Ting");

        Assert.Equal(1, board.Count);
        Assert.Equal(0, task.Count);
        Assert.Equal(1, item.Id);
    }

    [Fact]
    public void CopyContains_SameObjects()
    {
        var board = new MissionBoard();
        var item = board.Add("Tang");

        var copy = board.GetAll();

        Assert.Same(item, copy[0]);
    }

}
