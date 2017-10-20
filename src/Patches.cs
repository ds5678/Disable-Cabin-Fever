using Harmony;

namespace DisableCabinFever
{
    [HarmonyPatch(typeof(CabinFever), "Deserialize")]
    internal class CabinFever_Deserialize
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(CabinFever), "Update")]
    internal class CabinFever_Update
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}