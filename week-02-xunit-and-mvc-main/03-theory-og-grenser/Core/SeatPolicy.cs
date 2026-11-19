namespace SpaceAcademy;

public static class SeatPolicy
{
    public static bool CanReserve(int requested, int available)
    {
        return requested > 0 && requested <= available;
    }
}
