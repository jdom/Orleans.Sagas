﻿using System.Threading.Tasks;

namespace Orleans.Sagas.Samples.Activities
{
    public class KickAssActivity : Activity<KickAssConfig>
    {
        public override async Task Execute()
        {
            //Logger.Info($"Kicking ass {Config.KickAssCount} times...");
            for (int i = 0; i < Config.KickAssCount; i++)
            {
                //Logger.Info("Ass kicked.");
            }
        }

        public override Task Compensate()
        {
            return Task.CompletedTask;
        }
    }
}
