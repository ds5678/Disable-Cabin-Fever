using UnityEngine;

namespace DisableCabinFever
{
    internal class Implementation
    {
        public static void OnLoad()
        {
            Debug.Log("[Disable-Cabin-Fever]: Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}