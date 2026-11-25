using Xunit;
using SpaceAcademy;
using System.Reflection.PortableExecutable;

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
    public void GetPending_MixedBoard_ReturnsOnlyIncompleteTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        board.Complete(first.Id);
        var pending = board.GetPending();
        Assert.Single(pending);
        Assert.Same(second, pending[0]);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void GetPending_ReturnsEmptyList()
    {
        var board = new MissionBoard();

        var pending = board.GetPending();

        Assert.Empty(pending);
    }

    [Fact]
    public void GetPending_ReturnsIncompleteTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad Rover");
        var pending = board.GetPending();

        Assert.Equal(2, pending.Count);
        Assert.Same(first, pending[0]);
        Assert.Same(second, pending[1]);
    }

    [Fact]
    public void BoardWithTwoCompletedTasks_GetPendingReturnsEmptyList()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad Rover");

        first.Complete();
        second.Complete();

        var pending = board.GetPending();

        Assert.Empty(pending);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void BoardWithOneCompletedAndTwoUncompletedTasks_GetPendingReturnsUncompletedTaskInCorrectOrder()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad Rover");
        var third = board.Add("Kontroller drivstoff");

        second.Complete();

        var pending = board.GetPending();

        Assert.Same(first, pending[0]);
        Assert.Same(third, pending[1]);
        Assert.Equal(3, board.Count);
    }

    [Fact]
    public void A_NamedTest()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk");
        var second = board.Add("It");
        var pending = board.GetPending();

        Assert.Same(first, pending[0]);
        Assert.Same(second, pending[1]);

        pending.Clear();

        Assert.Equal(2, board.Count);

        pending = board.GetPending();

        Assert.Same(first, pending[0]);
        Assert.Same(second, pending[1]);

    }

}
