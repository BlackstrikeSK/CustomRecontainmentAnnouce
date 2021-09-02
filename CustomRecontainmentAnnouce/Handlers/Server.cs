using System;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace CustomRecontainmentAnnouce.Handlers
{
    class Server
    {
        public void OnSCPTermination(AnnouncingScpTerminationEventArgs ev)
        {
                Log.Info(ev.TerminationCause);
               /* if(ev.Role.roleId == RoleType.Scp93953)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP939MessageUn, false, false);
                    
                }

                if (ev.Role.roleId == RoleType.Scp93989)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP939MessageUn, false, false);

                }

                if (ev.Role.roleId == RoleType.Scp049)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP049MessageUn, false, false);

                }

                if (ev.Role.roleId == RoleType.Scp096)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP096MessageUn, false, false);

                }

                if (ev.Role.roleId == RoleType.Scp173)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP173MessageUn, false, false);

                }

                if (ev.Role.roleId == RoleType.Scp106)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP106MessageUn, false, false);

                }

                if (ev.Role.roleId == RoleType.Scp079)
                {
                    ev.IsAllowed = false;
                    Cassie.Message(Plugin.Instance.Config.SCP079MessageUn, false, false);

                }*/
        }
    }
}
