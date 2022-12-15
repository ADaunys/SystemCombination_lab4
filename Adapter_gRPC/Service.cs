namespace Server;

using NLog;
using Grpc.Core;

//this comes from GRPC generated code
using Services;


/// <summary>
/// Service. This is made to run as a singleton instance.
/// </summary>
public class Service : Services.Service.ServiceBase
{
    /// <summary>
    /// Logger for this class.
    /// </summary>
    Logger log = LogManager.GetCurrentClassLogger();

    /// <summary>
    /// Access lock.
    /// </summary>
    private AdapterLogic logic = new AdapterLogic();

    public override Task<CanSubtractLiquidOutput> CanSubtractLiquid(Empty empty, ServerCallContext context)
    {
        log.Info($"Service instance hash code: {this.GetHashCode()}.");

        lock (logic)
        {
            var result = new CanSubtractLiquidOutput { Value = logic.CanSubtractLiquid() };
            return Task.FromResult(result);
        }
    }

    public override Task<AddOutput> SubtractLiquid(Liquid input, ServerCallContext context)
    {
        log.Info($"Service instance hash code: {this.GetHashCode()}.");

        lock (logic)
        {
            var result = new AddOutput { Value = logic.SubtractLiquid(input.Amount) };
            return Task.FromResult(result);
        }
    }
}