using System.ComponentModel;
using Exiled.API.Interfaces;

namespace CustomRecontainmentAnnouce
{
    public sealed class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        // Unspecified Reason Messages
        [Description("SCP939 Message When Died Of UNSPECIFIED_REASON")]
        public string SCP939MessageUn { get; set; } = "Unspecified";

        [Description("SCP049 Message When Died Of UNSPECIFIED_REASON")]
        public string SCP049MessageUn { get; set; } = "Unspecified";

        [Description("SCP096 Message When Died Of UNSPECIFIED_REASON")]
        public string SCP096MessageUn { get; set; } = "Unspecified";

        [Description("SCP173 Message When Died Of UNSPECIFIED_REASON")]
        public string SCP173MessageUn { get; set; } = "Unspecified";

        [Description("SCP106 Message When Died Of UNSPECIFIED_REASON")]
        public string SCP106MessageUn { get; set; } = "Unspecified";

        [Description("SCP079 Message When Died Of UNSPECIFIED_REASON")]
        public string SCP079MessageUn { get; set; } = "Unspecified";
    }
}
