using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Server = Exiled.Events.Handlers.Server;
using Map = Exiled.Events.Handlers.Map;

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

        private Handlers.Server server;

        public override void OnEnabled()
        {
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            server = new Handlers.Server();

            Map.AnnouncingScpTermination += server.OnSCPTermination;
        }

        public void UnregisterEvents()
        {
            Map.AnnouncingScpTermination -= server.OnSCPTermination;
            server = null;
        }

    }
}
