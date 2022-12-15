namespace Server;

public interface IAdapter
{
    /// <summary>
    /// Check if liquid can be subtracted from the capacity
    /// </summary>
    /// <returns>boolean</returns>
    bool CanSubtractLiquid();

    /// <summary>
    /// Subtract liquid from the capacity
    /// </summary>
    /// <param name="amount">Amount of liquid to subtract</param>
    /// <returns>Amount of liquid to be subtracted</returns>
    int SubtractLiquid(int amount);
}