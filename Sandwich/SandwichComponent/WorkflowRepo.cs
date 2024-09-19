using Microsoft.Extensions.Options;

namespace SandwichComponent
{
    public class WorkflowRepoConfig
    {
        public string MakePBJFileName { get; set; }
    }

    public class WorkflowRepo
    {
        private readonly WorkflowRepoConfig _config;

        public WorkflowRepo(IOptionsSnapshot<WorkflowRepoConfig> config)
        {
            _config = config.Value;
        }

        public async Task<string> MakePBJ()
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, _config.MakePBJFileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{_config.MakePBJFileName}' was not found at path '{filePath}'.");
            }
            return await File.ReadAllTextAsync(filePath);
        }
    }
}
