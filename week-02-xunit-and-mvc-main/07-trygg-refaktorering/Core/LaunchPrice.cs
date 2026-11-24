namespace SpaceAcademy;

public static class LaunchPrice
{
    public static int Calculate(int count, bool priority)
    {
        if (priority)
        {
            return count * 120;
        }
        else
        {
            return count * 100;
        }
    }
}
