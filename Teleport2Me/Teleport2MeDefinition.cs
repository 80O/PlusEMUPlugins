using Plus.Plugins;

namespace Teleport2Me
{
    public class Teleport2MeDefinition : IPluginDefinition
    {
        public string Name => "Teleport2Me Plugin";
        public string Author => "Harb#9937";
        public Version Version => new(1, 0, 1);
        public Type PluginClass => typeof(Teleport2Me);
    }
}
