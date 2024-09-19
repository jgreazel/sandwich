using WorkflowCore.Interface;

namespace SandwichComponent
{
    public class SandwichService
    {
        private IWorkflowHost _wfHost;

        public SandwichService(IWorkflowHost wfHost)
        {
            _wfHost = wfHost;
        }

        public Sandwich MakeSandwich()
        {
            var sw = new Sandwich();
            var data = new MakePBJData { Sandwich = sw };
            _wfHost.StartWorkflow("MakePBJ", data);
            return sw;
        }

    }
}