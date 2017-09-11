using Amatsu;
using Meebey.SmartIrc4net;

namespace ExamplePlugin
{
    public class ExamplePluginClass : AmatsuPlugin
    {
        public void RegisterCommands(CommandsManager commandsManager)
        {
            commandsManager.Register();
        }
    }
}
