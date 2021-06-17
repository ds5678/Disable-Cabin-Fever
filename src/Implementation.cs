using UnityEngine;
using System.Reflection;
using MelonLoader;

namespace DisableCabinFever
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
        }
    }
}