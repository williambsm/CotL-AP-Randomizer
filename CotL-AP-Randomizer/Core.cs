using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(CotL_AP_Randomizer.Core), "CotL-AP-Randomizer", "1.0.0", "williambsm", null)]
[assembly: MelonGame("Massive Monster", "Cult Of The Lamb")]

namespace CotL_AP_Randomizer
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("A sheep has been sacrificed.");
        }
    }
}