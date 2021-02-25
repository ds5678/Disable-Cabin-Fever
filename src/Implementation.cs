﻿using UnityEngine;
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

        internal static void Log(string message)
        {
            MelonLoader.MelonLogger.Log(message);
        }

        internal static void Log(string message, params object[] parameters)
        {
            string preformattedMessage = string.Format( message, parameters);
            Log(preformattedMessage);
        }
    }
}