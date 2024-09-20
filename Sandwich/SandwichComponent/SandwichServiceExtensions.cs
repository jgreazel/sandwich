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
            // then utilize inside of api project
            // fix double json file thing (proj and sol)
            // https://chatgpt.com/c/66eb9fd3-546c-800d-8d59-ecdee2f37925
            // https://github.com/danielgerlag/workflow-core/blob/master/src/samples/WorkflowCore.Sample01/Program.cs
            // https://workflow-core.readthedocs.io/en/latest/getting-started/ 
            return services;
        }
    }
}
