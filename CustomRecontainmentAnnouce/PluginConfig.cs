using System;
using Exiled.API.Interfaces;

namespace CustomRecontainmentAnnouce
{
    public sealed class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        // Unspecified Reason Message
        public string SCP939MessageUn { get; set; } = "";

        public string SCP049MessageUn { get; set; } = "";

        public string SCP096MessageUn { get; set; } = "";

        public string SCP173MessageUn { get; set; } = "";

        public string SCP106MessageUn { get; set; } = "";

        public string SCP079MessageUn { get; set; } = "";
    }
}
