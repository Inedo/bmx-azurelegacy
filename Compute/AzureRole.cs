using System;
using Inedo.Serialization;

namespace Inedo.BuildMasterExtensions.Azure
{
    [SlimSerializable]
    [Serializable]
    public class AzureRole
    {
        [Persistent]
        public string RoleName { get; set; }

        [Persistent]
        public string RoleBinDirectory { get; set; }

        [Persistent]
        public string RoleAssemblyName { get; set; }
    }
}
