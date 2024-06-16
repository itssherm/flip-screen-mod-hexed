using CoreRuntime.Interfaces;
using CoreRuntime.Manager;
using FlipaScreen;
using Il2CppSystem;
using System.Collections;
using UnityEngine;

namespace Basse
{
    public class FlipScreen : HexedCheat
    {
        public override void OnLoad(string[] args)
        {
            MonoManager.PatchUpdate(typeof(VRCApplication).GetMethod(nameof(VRCApplication.Update)));
            MonoManager.PatchOnApplicationQuit(typeof(VRCApplicationSetup).GetMethod(nameof(VRCApplicationSetup.OnApplicationQuit))); // Optional Hook to enable the OnApplicationQuit callback
        }



        public override void OnUpdate()
        {
            headflippa.Update();
        }

    }
}