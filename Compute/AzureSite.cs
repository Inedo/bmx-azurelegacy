using System;
using Inedo.Serialization;

namespace Inedo.BuildMasterExtensions.Azure
{
    [SlimSerializable]
    [Serializable]
    public class AzureSite
    {
        [Persistent]
        public string RoleName { get; set; }

        [Persistent]
        public string VirtualPath { get; set; }

        [Persistent]
        public string PhysicalPath { get; set; }
    }
}
