using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace SandwichComponent
{
    public class PlateSandwich : StepBody
    {

        public required Sandwich Input { get; set; }
        public required Sandwich Output { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Input.Plated = true;
            Output = Input;
            return ExecutionResult.Next();
        }
    }
}
