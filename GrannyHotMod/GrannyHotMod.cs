using Terraria.ID;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace GrannyHotMod
{
    class GrannyHotMod : Mod
    {
        public GrannyHotMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
            };
        }
    }
}