namespace Servers;

using NLog;
using ServiceReference;
using Services;

/// <summary>
/// Service logic.
/// </summary>
class ServiceLogic : IService
{
    /// <summary>
    /// Logger for this class.
    /// </summary>
    private static readonly HttpClient Client = new();

    public bool CanAddLiquid()
    {
        Console.WriteLine();
        Console.WriteLine($"Forwarding CanAddLiquid() request from gRPC client to REST server");
        Console.WriteLine();

        var service = new FillService("http://127.0.0.1:5000", new HttpClient());
        return service.CanAddLiquid();
    }

    public int AddLiquid(int amount)
    {
        Console.WriteLine();
        Console.WriteLine($"Forwarding AddLiquid() request from gRPC client to REST server");
        Console.WriteLine();

        var service = new FillService("http://127.0.0.1:5000", new HttpClient());
        return service.AddLiquid(amount);
    }
}