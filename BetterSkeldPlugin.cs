using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Reactor;
using Reactor.Patches;



namespace ChallengerBetterSkeld
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class BetterSkeldPlugin : BasePlugin
    {
        public const string Id = "challenger.Lunastellia.betterSkeld";

        public Harmony Harmony { get; } = new Harmony(Id);
        public static ManualLogSource log;


        public override void Load()
        
        {
            log = Log;
            log.LogMessage("Challenger Better Skeld Mod loaded");
            
            Harmony.PatchAll();
        }
    }
}

