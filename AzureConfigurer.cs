using Inedo.BuildMaster.Extensibility.Configurers.Extension;
using Inedo.Serialization;

[assembly: ExtensionConfigurer(typeof(Inedo.BuildMasterExtensions.Azure.AzureConfigurer))]

namespace Inedo.BuildMasterExtensions.Azure
{
    [Inedo.Web.CustomEditor(typeof(AzureConfigurerEditor))]
    [PersistFrom("Inedo.BuildMasterExtensions.Azure.AzureConfigurer,Azure")]
    public sealed class AzureConfigurer : ExtensionConfigurerBase
    {
        [Persistent]
        public string AzureSDKPath { get; set; }
        [Persistent]
        public int ServerID { get; set; } = 1;
        [Persistent]
        public AzureAuthentication Credentials { get; set; } = new AzureAuthentication();
    }
}
