using Inedo.BuildMaster.Extensibility.Actions;

namespace Inedo.BuildMasterExtensions.Azure
{
    internal sealed class DeleteDeploymentActionEditor : AzureComputeActionBaseEditor 
    {

        public DeleteDeploymentActionEditor() 
        {
            this.extensionInstance = new DeleteDeploymentAction();
        }

        public override void BindToForm(ActionBase extension)
        {
            this.EnsureChildControls();
            base.BindToForm(extension);
        }

        public override ActionBase CreateFromForm()
        {
            this.EnsureChildControls();

            return PopulateProperties(new DeleteDeploymentAction());
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
        }
    }
}
