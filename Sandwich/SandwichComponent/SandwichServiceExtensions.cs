using Microsoft.Extensions.DependencyInjection;


namespace SandwichComponent
{
    public static class SandwichServiceExtensions
    {
        public static IServiceCollection AddSandwichService(this IServiceCollection services)
        {
            // configure wf repo from config
            // add workflow core deps
            // add service
            return services;
        }
    }
}
