namespace Servers;

using Services;


/// <summary>
/// Service
/// </summary>
public class Service : IService
{
    /// <summary>
    /// Access lock.
    /// </summary>
    private readonly Object accessLock = new Object();

    /// <summary>
    /// Service logic implementation.
    /// </summary>
    private ServiceLogic logic = new ServiceLogic();

    /// <summary>
    /// Check if liquid can be added to the capacity
    /// </summary>
    /// <returns>boolean</returns>
    public bool CanAddLiquid()
    {
        lock (accessLock)
        {
            return logic.CanAddLiquid();
        }
    }

    /// <summary>
    /// Add liquid to the capacity
    /// </summary>
    /// <param name="amount">Amount of liquid to add</param>
    /// <returns>Amount of liquid to be added</returns>
    public int AddLiquid(int amount)
    {
        lock (accessLock)
        {
            return logic.AddLiquid(amount);
        }
    }
}