using System;
using Exiled.API.Interfaces;

namespace CustomRecontainmentAnnouce
{
    public sealed class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
