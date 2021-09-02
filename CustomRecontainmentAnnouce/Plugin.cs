using System;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace CustomRecontainmentAnnouce
{
    public class Plugin : Plugin<PluginConfig>
    {
        private static readonly Plugin Singleton = new Plugin();

        public override string Author => "BlackstrikeSK";
        public override string Name => "CustomRecontainmentAnnouce";
        public override PluginPriority Priority => PluginPriority.Medium;
        public override Version RequiredExiledVersion => new Version(2, 14, 0);
        public override Version Version => new Version(1, 0, 0);

        public static Plugin Instance => Singleton;


    }
}
