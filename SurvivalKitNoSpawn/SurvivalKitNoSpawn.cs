using NLog;
using System;
using System.IO;
using Torch;
using Torch.API;

namespace SurvivalKitNoSpawn
{
    public class SurvivalKitNoSpawn : TorchPluginBase
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public Logger Logger = Log;

        /// <inheritdoc />
        public override void Init(ITorchBase torch)
        {
            base.Init(torch);

        }

    }
}
