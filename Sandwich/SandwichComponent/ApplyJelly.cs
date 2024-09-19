using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace SandwichComponent
{
    public class ApplyJelly : StepBody
    {

        public required Sandwich Input { get; set; }
        public required Sandwich Output { get; set; }
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Input.JellyApplied = true;
            Output = Input; return ExecutionResult.Next();
        }
    }
}
