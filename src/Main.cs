using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace RagdollFix
{
    public class Main : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            var harmony = new Harmony("com.yourname.ragdollfix");
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(Agent), "SetVelocityLimitsOnRagdoll")]
    public static class RagdollVelocityPatch
    {
        static void Prefix(Agent __instance, ref float linearVelocityLimit)
        {
            linearVelocityLimit = 5f;
        }
    }
}