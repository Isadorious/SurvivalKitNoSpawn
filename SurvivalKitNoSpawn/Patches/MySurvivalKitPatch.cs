using System;
using System.Reflection;
using SpaceEngineers.Game.Entities.Blocks;
using Sandbox.Game.EntityComponents;
using Torch.Managers.PatchManager;
using Torch.Utils;
using NLog;
using VRage.Game;
using Sandbox.Game.Entities;

namespace SurvivalKitNoSpawn
{
    [PatchShim]
    public static class MySurvivalKitPatch
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        internal static readonly MethodInfo Init = typeof(MySurvivalKit).GetMethod(nameof(MySurvivalKit.Init), new[] { typeof(MyObjectBuilder_CubeBlock), typeof(MyCubeGrid) }) ?? throw new Exception("Failed to find patch method");
        internal static readonly MethodInfo InitPatch = typeof(MySurvivalKitPatch).GetMethod(nameof(InitPatchMethod), BindingFlags.Static | BindingFlags.Public) ?? throw new Exception("Failed to find patch method");

        public static void InitPatchMethod(MySurvivalKit __instance)
        {
            if (__instance.CubeGrid.CreatePhysics)
            {
                __instance.Components.Remove<MyEntityRespawnComponentBase>();
            }
        }

        public static void Patch(PatchContext ctx)
        {
            ctx.GetPattern(Init).Suffixes.Add(InitPatch);
            Log.Info("Patching Successful MySurvivalKit");
        }
    }
}
