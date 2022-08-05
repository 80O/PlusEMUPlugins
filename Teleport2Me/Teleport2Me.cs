using Plus.Plugins;

namespace Teleport2Me;

public class Teleport2Me : IPlugin
{
    public void Start()
    {
        var pluginInfo = new Teleport2MeDefinition();
        Logger(pluginInfo.Name + " by " + pluginInfo.Author + " has started.");
    }

    private void Logger(string message)
    {
        var pluginInfo = new Teleport2MeDefinition();
        var CYAN = "\u001b[34m";
        var WHITE = "\u001b[37m";
        Console.WriteLine(WHITE + "[" + CYAN + pluginInfo.Name + WHITE + "] " + message);
    }

}