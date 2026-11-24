namespace SpaceAcademy;

public static class LaunchPolicy
{
    public static bool CanLaunch(int fuel, bool safetyApproved)
    {
        if (fuel >= 50 && safetyApproved)
        {
            return true;
        }
        return false;
    }
}
